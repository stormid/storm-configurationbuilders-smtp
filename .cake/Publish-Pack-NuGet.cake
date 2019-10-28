#load "Configuration.cake"

Task("Publish:Pack:NuGet")
    .IsDependeeOf("Publish")
    .WithCriteria<Configuration>((ctx, config) => config.Solution.NuGetProjects.Any())
    .Does<Configuration>(config => 
{
    var projectArtifactDirectory = config.Artifacts.GetRootFor(ArtifactTypeOption.NuGet);

    foreach(var nugetProject in config.Solution.NuGetProjects) {
     var properties = new Dictionary<string,string>{ { "Configuration", "Release"} };   
     var nuGetPackSettings   = new NuGetPackSettings {
                                     Version                 = $"{config.Version.SemVersion}",
                                     OutputDirectory         = $"{projectArtifactDirectory}/",
                                     Properties              = properties
                                 };

        NuGetPack(nugetProject.ProjectFilePath.ToString(), nuGetPackSettings);
    }

    foreach(var package in GetFiles($"{projectArtifactDirectory}/*.nupkg")) 
    {    
        config.Artifacts.Add(ArtifactTypeOption.NuGet, package.GetFilename().ToString(), package.FullPath);
    }
});
