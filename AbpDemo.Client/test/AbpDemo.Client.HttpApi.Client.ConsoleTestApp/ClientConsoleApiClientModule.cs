using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpDemo.Client
{
    [DependsOn(
        typeof(ClientHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ClientConsoleApiClientModule : AbpModule
    {
        
    }
}
