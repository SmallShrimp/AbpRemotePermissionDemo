using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpDemo.ClientApp.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ClientAppMigrationsDbContextFactory : IDesignTimeDbContextFactory<ClientAppMigrationsDbContext>
    {
        public ClientAppMigrationsDbContext CreateDbContext(string[] args)
        {
            ClientAppEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ClientAppMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ClientAppMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
