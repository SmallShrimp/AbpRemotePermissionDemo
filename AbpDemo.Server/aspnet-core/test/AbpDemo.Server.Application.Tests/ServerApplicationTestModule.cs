using Volo.Abp.Modularity;

namespace AbpDemo.Server
{
    [DependsOn(
        typeof(ServerApplicationModule),
        typeof(ServerDomainTestModule)
        )]
    public class ServerApplicationTestModule : AbpModule
    {

    }
}