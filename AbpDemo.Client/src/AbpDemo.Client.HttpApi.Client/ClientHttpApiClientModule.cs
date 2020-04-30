using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace AbpDemo.Client
{
    [DependsOn(
        typeof(ClientApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ClientHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Client";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ClientApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
