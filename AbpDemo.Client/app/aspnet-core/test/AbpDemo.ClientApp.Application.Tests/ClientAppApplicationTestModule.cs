using Volo.Abp.Modularity;

namespace AbpDemo.ClientApp
{
    [DependsOn(
        typeof(ClientAppApplicationModule),
        typeof(ClientAppDomainTestModule)
        )]
    public class ClientAppApplicationTestModule : AbpModule
    {

    }
}