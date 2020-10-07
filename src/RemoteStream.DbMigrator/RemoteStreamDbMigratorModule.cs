using RemoteStream.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace RemoteStream.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(RemoteStreamEntityFrameworkCoreDbMigrationsModule),
        typeof(RemoteStreamApplicationContractsModule)
        )]
    public class RemoteStreamDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
