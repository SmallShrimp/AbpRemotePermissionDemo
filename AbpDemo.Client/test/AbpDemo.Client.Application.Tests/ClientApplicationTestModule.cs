using Volo.Abp.Modularity;

namespace AbpDemo.Client
{
    [DependsOn(
        typeof(ClientApplicationModule),
        typeof(ClientDomainTestModule)
        )]
    public class ClientApplicationTestModule : AbpModule
    {

    }
}
