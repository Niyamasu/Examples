using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Configuration.DefaultConfiguration;

public interface IDefaultConfiguration
{
    public IConfigurationRoot GetConfigurationRoot();

    public string GetConnectionString();
    
}