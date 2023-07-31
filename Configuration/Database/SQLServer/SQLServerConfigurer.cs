using Configuration.DefaultConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Configuration.Database.SQLServer;

public static class SQLServerConfigurer
{
    public static IDefaultConfiguration SetDbContextOptionsBuilderConfigurationFromAppSecrets<
        TypeFromAssemblyOwningUserSecret>(
        DbContextOptionsBuilder optionsBuilder)
        where TypeFromAssemblyOwningUserSecret : class
    {
        if (optionsBuilder.IsConfigured == false)
        {
            DefaultConfigurationFactory defaultConfigurationFactory = new();
            IDefaultConfiguration defaultConfiguration =
                defaultConfigurationFactory
                    .GetDefaultConfiguration<TypeFromAssemblyOwningUserSecret>();

            string connectionString = defaultConfiguration.GetConnectionString();
            
            optionsBuilder.UseSqlServer(connectionString);

            return defaultConfiguration;
        }
        else
        {
            return null;
        } // End of instruction else.
        
    } // End of method SetDbContextOptionsBuilderConfigurationFromAppSecrets.
    
} // End of class SQLServerConfigurer.