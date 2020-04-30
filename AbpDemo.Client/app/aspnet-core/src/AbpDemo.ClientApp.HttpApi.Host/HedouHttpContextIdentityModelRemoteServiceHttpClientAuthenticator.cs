using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Http.Client.IdentityModel.Web;
using Volo.Abp.IdentityModel;

namespace AbpDemo.ClientApp
{
    public class HedouHttpContextIdentityModelRemoteServiceHttpClientAuthenticator :
      HttpContextIdentityModelRemoteServiceHttpClientAuthenticator
    {
        public HedouHttpContextIdentityModelRemoteServiceHttpClientAuthenticator(IIdentityModelAuthenticationService identityModelAuthenticationService)
            : base(identityModelAuthenticationService)
        {
        }

        /// <summary>
        /// 重写 才能获取到token
        /// </summary>
        /// <returns></returns>
        protected override async Task<string> GetAccessTokenFromHttpContextOrNullAsync()
        {
            var httpContext = HttpContextAccessor?.HttpContext;
            if (httpContext == null)
            {
                return null;
            }

            string token = await httpContext.GetTokenAsync(JwtBearerDefaults.AuthenticationScheme, "access_token");
            if (token.IsNullOrEmpty())
            {
                string authHeader = httpContext.Request.Headers["Authorization"];
                token = authHeader?.Replace("Bearer ", "");
            }
            return token;
        }
    }
}
