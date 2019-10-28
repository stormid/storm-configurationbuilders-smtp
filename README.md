# Storm.ConfigurationBuilders.Smtp

[![Build Status](https://dev.azure.com/storm-id-oss/Storm.Umbraco/_apis/build/status/Storm.ConfigurationBuilders.Smtp?branchName=master)](https://dev.azure.com/storm-id-oss/Storm.Umbraco/_build/latest?definitionId=12&branchName=master)

Uses [configuration builders](https://docs.microsoft.com/en-us/aspnet/config-builder) added in .Net 471 to create a SMTP section in the web.config using values set in AppSettings. Useful for changing SMTP settings between environments.

## Setup
All necessary classes and config changes should be added as part of the package installation, all that remains is to fill in the following keys in the AppSettings section with the appropriate values. 

```
    <add key="Smtp:Host" value="localhost" />
    <add key="Smtp:Port" value="25" />
    <add key="Smtp:Username" value="" />
    <add key="Smtp:Password" value="" />
    <add key="Smtp:EnableSsl" value="false" />
```



