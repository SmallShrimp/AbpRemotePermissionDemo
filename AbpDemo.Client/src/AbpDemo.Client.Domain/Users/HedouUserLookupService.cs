using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Uow;
using Volo.Abp.Users;

namespace AbpDemo.Client.Users
{
    public class HedouUserLookupService : UserLookupService<HedouUser, IHedouUserRepository>, IHedouUserLookupService
    {

        public HedouUserLookupService(
           IHedouUserRepository userRepository,
           IUnitOfWorkManager unitOfWorkManager)
           : base(
               userRepository,
               unitOfWorkManager)
        {

        }

        protected override HedouUser CreateUser(IUserData externalUser)
        {
            return new HedouUser(externalUser);
        }
    }
}
