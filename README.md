# Storm.Umbraco.Smtp
Configuration package for Umbraco

Uses .Net 471 configuration builders to build the Smtp section of the web.config. This allows the smtp settings to be set via app settings which can be changed per environment.

## What's in the box?
- Adds necessary configuration builder classes
- Adds configuration config to the web.config
- Adds app settings - by default set up to use localhost:25
```
    <add key="Smtp:Host" value="localhost" />
    <add key="Smtp:Port" value="25" />
    <add key="Smtp:Username" value="" />
    <add key="Smtp:Password" value="" />
    <add key="Smtp:EnableSsl" value="false" />
```

## What do I need to do?
- Add the details of your desired smtp server to the app settings



