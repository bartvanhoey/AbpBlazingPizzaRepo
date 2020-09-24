using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BlazingPizza.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class BlazingPizzaMigrationsDbContextFactory : IDesignTimeDbContextFactory<BlazingPizzaMigrationsDbContext>
    {
        public BlazingPizzaMigrationsDbContext CreateDbContext(string[] args)
        {
            BlazingPizzaEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BlazingPizzaMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new BlazingPizzaMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BlazingPizza.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
