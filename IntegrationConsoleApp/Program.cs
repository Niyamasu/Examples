using Configuration.DefaultConfiguration;

// var builder = new ConfigurationBuilder()
//     .SetBasePath(Directory.GetCurrentDirectory())
//     .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
//     .AddUserSecrets<Program>().AddEnvironmentVariables();
// IConfigurationRoot configurationRoot = builder.Build();



// Database? test1 = configurationRoot.GetSection("Database").Get<Database>();
// var x =configurationRoot.GetSection(nameof(Database)+ ":" + nameof(Database.ConnectionString) );
// var y = x.Get<Database>();
//var t = configurationRoot.//.GetSection(nameof(Database));

//Console.WriteLine(nameof(Database.ConnectionString));


//string dbConnectionString = "Server=127.0.0.1;Database=Test;Trusted_Connection=True;";


// DbContextOptions<ProductDbContext> optionsBuilder = new DbContextOptionsBuilder<ProductDbContext>()
//     .UseSqlServer(dbConnectionString).Options;
//
// ProductDbContext t = new (optionsBuilder);

DefaultConfigurationFactory defaultConfigurationFactory = new();
IDefaultConfiguration defaultConfiguration = defaultConfigurationFactory.GetDefaultConfiguration<Program>();
var teste =defaultConfiguration.GetConfigurationRoot();
var teste2 = defaultConfiguration.GetConnectionString();

//HttpClient httpClient = new();


//IntegrationData.ShowInformation(httpClient);


Console.WriteLine();

Console.WriteLine("Press any key to end");
Console.ReadLine();