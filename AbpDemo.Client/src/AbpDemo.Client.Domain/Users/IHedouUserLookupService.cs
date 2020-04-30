using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Users;

namespace AbpDemo.Client.Users
{
    public interface IHedouUserLookupService : IUserLookupService<HedouUser>
    {
    }
}
