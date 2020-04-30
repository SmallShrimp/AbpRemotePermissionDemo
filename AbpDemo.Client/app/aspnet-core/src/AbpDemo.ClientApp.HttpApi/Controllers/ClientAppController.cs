using AbpDemo.ClientApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpDemo.ClientApp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ClientAppController : AbpController
    {
        protected ClientAppController()
        {
            LocalizationResource = typeof(ClientAppResource);
        }
    }
}