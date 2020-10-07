using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RemoteStream.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class RemoteStreamMigrationsDbContextFactory : IDesignTimeDbContextFactory<RemoteStreamMigrationsDbContext>
    {
        public RemoteStreamMigrationsDbContext CreateDbContext(string[] args)
        {
            RemoteStreamEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<RemoteStreamMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new RemoteStreamMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../RemoteStream.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
