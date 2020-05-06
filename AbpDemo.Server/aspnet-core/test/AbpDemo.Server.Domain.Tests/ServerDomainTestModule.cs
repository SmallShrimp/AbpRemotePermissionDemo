using AbpDemo.Server.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpDemo.Server
{
    [DependsOn(
        typeof(ServerEntityFrameworkCoreTestModule)
        )]
    public class ServerDomainTestModule : AbpModule
    {

    }
}