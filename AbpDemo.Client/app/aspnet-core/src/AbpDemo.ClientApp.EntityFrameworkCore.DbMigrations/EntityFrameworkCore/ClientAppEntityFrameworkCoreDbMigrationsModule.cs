using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpDemo.ClientApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(ClientAppEntityFrameworkCoreModule)
        )]
    public class ClientAppEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ClientAppMigrationsDbContext>();
        }
    }
}
