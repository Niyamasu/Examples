using Configuration.Database.SQLServer;
using Microsoft.EntityFrameworkCore;

namespace Database.Product;

public class ProductDbContext : DbContext
{
    // Add a default constructor if scaffolding is needed.

    public ProductDbContext()
    {
    }

    //  Add the complex constructor for allowing Dependency Injection.
    public ProductDbContext(DbContextOptions<ProductDbContext> options) :
        base(options)
    {
    } // End of ctor.

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        SQLServerConfigurer.SetDbContextOptionsBuilderConfigurationFromAppSecrets<ProductDbContext>(optionsBuilder);

        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Models.Product> Products => Set<Models.Product>();
    
} // End of class ProductDBContext.
