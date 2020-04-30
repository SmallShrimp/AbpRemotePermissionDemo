using System;
using System.Collections.Generic;
using System.Text;
using AbpDemo.ClientApp.Localization;
using Volo.Abp.Application.Services;

namespace AbpDemo.ClientApp
{
    /* Inherit your application services from this class.
     */
    public abstract class ClientAppAppService : ApplicationService
    {
        protected ClientAppAppService()
        {
            LocalizationResource = typeof(ClientAppResource);
        }
    }
}
