using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace RemoteStream.EntityFrameworkCore
{
    [DependsOn(
        typeof(RemoteStreamEntityFrameworkCoreModule)
        )]
    public class RemoteStreamEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<RemoteStreamMigrationsDbContext>();
        }
    }
}
