using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DeployOnPrSample.Data;

public class DeployOnPrSampleDbContextFactory : IDesignTimeDbContextFactory<DeployOnPrSampleDbContext>
{
    public DeployOnPrSampleDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DeployOnPrSampleDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));

        return new DeployOnPrSampleDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
