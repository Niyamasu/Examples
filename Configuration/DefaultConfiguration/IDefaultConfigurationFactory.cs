namespace Configuration.DefaultConfiguration;

public interface IDefaultConfigurationFactory
{
    public IDefaultConfiguration GetDefaultConfiguration<TypeFromAssemblyOwningUserSecret>()
        where TypeFromAssemblyOwningUserSecret : class;
}