using AbpDemo.Server.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpDemo.Server.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ServerController : AbpController
    {
        protected ServerController()
        {
            LocalizationResource = typeof(ServerResource);
        }
    }
}