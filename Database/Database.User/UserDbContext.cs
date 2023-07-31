
using Configuration.Database.SQLServer;
using Microsoft.EntityFrameworkCore;

namespace Database.User;

public class UserDbContext : DbContext
{
    // Add a default constructor if scaffolding is needed.
    public UserDbContext() {}
    
    //  Add the complex constructor for allowing Dependency Injection.
    public UserDbContext(DbContextOptions<UserDbContext> options) :
        base(options) {} // End of ctor.
    
    public DbSet<Models.User.User> Users => Set<Models.User.User>();
    public DbSet<Models.User.Gender> Genders => Set<Models.User.Gender>();
    public DbSet<Models.User.BloodType> BloodTypes => Set<Models.User.BloodType>();
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        SQLServerConfigurer.SetDbContextOptionsBuilderConfigurationFromAppSecrets<UserDbContext>(optionsBuilder);

        base.OnConfiguring(optionsBuilder);
    }
    
    
} // End of class UserDbContext