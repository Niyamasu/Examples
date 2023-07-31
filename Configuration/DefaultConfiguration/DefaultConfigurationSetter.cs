
using Microsoft.Extensions.Configuration;

namespace Configuration.DefaultConfiguration;

internal class DefaultConfigurationSetter<TypeFromAssemblyOwningUserSecret> : IDefaultConfiguration where TypeFromAssemblyOwningUserSecret : class
{
    public IConfigurationRoot ConfigurationRoot { get; private set; }

    public string ConnectionString { get; private set; }

    internal DefaultConfigurationSetter()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddUserSecrets<TypeFromAssemblyOwningUserSecret>()
            .AddEnvironmentVariables();
        IConfigurationRoot configurationRoot = builder.Build();
        ConfigurationRoot = configurationRoot;
        
            UserSecrets.Database? database = configurationRoot.GetSection("Database").Get<UserSecrets.Database>();

        ConnectionString = database?.ConnectionString ?? string.Empty;
        // ServiceProvider services = new ServiceCollection()
        //     .Configure<AppSecrets>(configurationRoot.GetSection(nameof(AppSecrets)))
        //     .AddOptions()
        //     .BuildServiceProvider();
        //
        // AppSecrets testAppSecrets = services.GetRequiredService<IOptions<AppSecrets>>().Value;
    }

    public IConfigurationRoot GetConfigurationRoot()
        => ConfigurationRoot;

    public string GetConnectionString()
        => ConnectionString;


} // End of class ConfigurationSetter.