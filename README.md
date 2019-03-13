# Storm.Umbraco.Smtp
Configuration package for Umbraco

Dynamically creates the SMTP section of the web.config using a [.Net 471 configuration builder.](https://docs.microsoft.com/en-us/aspnet/config-builder) 

SMTP settings are then specified through appsettings, meaning they can be changed between environments.

## What's in the box?
- Adds configuration builder & settings classes
- Adds the configuration builder to the web.config
- Adds appsettings - by default set up to use localhost:25
```
    <add key="Smtp:Host" value="localhost" />
    <add key="Smtp:Port" value="25" />
    <add key="Smtp:Username" value="" />
    <add key="Smtp:Password" value="" />
    <add key="Smtp:EnableSsl" value="false" />
```

## What do I need to do?
- Change the appsetting values to the details of your desired SMTP server.



