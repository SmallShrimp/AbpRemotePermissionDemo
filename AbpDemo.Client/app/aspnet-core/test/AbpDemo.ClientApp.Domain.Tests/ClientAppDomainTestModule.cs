using AbpDemo.ClientApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpDemo.ClientApp
{
    [DependsOn(
        typeof(ClientAppEntityFrameworkCoreTestModule)
        )]
    public class ClientAppDomainTestModule : AbpModule
    {

    }
}