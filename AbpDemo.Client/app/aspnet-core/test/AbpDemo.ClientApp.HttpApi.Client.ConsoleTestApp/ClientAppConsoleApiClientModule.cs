using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpDemo.ClientApp.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ClientAppHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ClientAppConsoleApiClientModule : AbpModule
    {
        
    }
}
