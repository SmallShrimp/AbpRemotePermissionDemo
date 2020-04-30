using Volo.Abp.Modularity;
using Volo.Abp.Users;

namespace AbpDemo.Client
{
    [DependsOn(
        typeof(ClientDomainSharedModule),
        typeof(AbpUsersDomainModule)
        )]
    public class ClientDomainModule : AbpModule
    {

    }
}
