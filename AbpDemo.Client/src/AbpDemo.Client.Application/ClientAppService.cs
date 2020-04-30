using AbpDemo.Client.Localization;
using Volo.Abp.Application.Services;

namespace AbpDemo.Client
{
    public abstract class ClientAppService : ApplicationService
    {
        protected ClientAppService()
        {
            LocalizationResource = typeof(ClientResource);
            ObjectMapperContext = typeof(ClientApplicationModule);
        }
    }
}
