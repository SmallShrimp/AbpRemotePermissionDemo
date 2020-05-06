using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpDemo.Server.EntityFrameworkCore
{
    [DependsOn(
        typeof(ServerEntityFrameworkCoreModule)
        )]
    public class ServerEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ServerMigrationsDbContext>();
        }
    }
}
