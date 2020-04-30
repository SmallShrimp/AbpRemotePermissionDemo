using AbpDemo.ClientApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpDemo.ClientApp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ClientAppEntityFrameworkCoreDbMigrationsModule),
        typeof(ClientAppApplicationContractsModule)
        )]
    public class ClientAppDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
