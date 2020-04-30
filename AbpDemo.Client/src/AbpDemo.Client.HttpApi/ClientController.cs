using AbpDemo.Client.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpDemo.Client
{
    public abstract class ClientController : AbpController
    {
        protected ClientController()
        {
            LocalizationResource = typeof(ClientResource);
        }
    }
}
