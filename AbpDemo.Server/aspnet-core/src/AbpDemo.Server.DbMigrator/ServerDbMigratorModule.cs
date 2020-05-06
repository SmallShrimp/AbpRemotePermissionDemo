using AbpDemo.Server.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpDemo.Server.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ServerEntityFrameworkCoreDbMigrationsModule),
        typeof(ServerApplicationContractsModule)
        )]
    public class ServerDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
