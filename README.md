# Storm-ConfigurationBuilders-Smtp
Uses [configuration builders](https://docs.microsoft.com/en-us/aspnet/config-builder) added in .Net 471 to create a SMTP element in the web.config using values set in AppSettings. Useful for changing SMTP settings between environments.

## What's in the box?
- Configuration builder & settings classes
- Adds the configuration builder set up to the web.config
- Adds default app settings (set to use localhost:25)
```
    <add key="Smtp:Host" value="localhost" />
    <add key="Smtp:Port" value="25" />
    <add key="Smtp:Username" value="" />
    <add key="Smtp:Password" value="" />
    <add key="Smtp:EnableSsl" value="false" />
```



