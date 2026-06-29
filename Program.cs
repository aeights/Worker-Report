using Worker_Report;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, config) =>
    {
        config.Sources.Clear();
        config.AddYamlFile("appsettings.yaml", optional: false, reloadOnChange: true);

        var env = context.HostingEnvironment.EnvironmentName;
        config.AddYamlFile($"appsettings.{env}.yaml", optional: true, reloadOnChange: true);

        config.AddEnvironmentVariables();
    })
    .ConfigureServices((context, services) =>
    {
        services.AddApplicationServices(context.Configuration, context.HostingEnvironment);
    })
    .Build();

await host.RunAsync();
