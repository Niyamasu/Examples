namespace Configuration.DefaultConfiguration;

public class DefaultConfigurationFactory : IDefaultConfigurationFactory
{
    public IDefaultConfiguration GetDefaultConfiguration<TypeFromAssemblyOwningUserSecret>()
        where TypeFromAssemblyOwningUserSecret : class
        => new DefaultConfigurationSetter<TypeFromAssemblyOwningUserSecret>();
    
}