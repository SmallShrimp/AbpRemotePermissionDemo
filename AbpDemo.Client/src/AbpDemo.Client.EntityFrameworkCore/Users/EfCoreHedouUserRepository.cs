using AbpDemo.Client.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Users.EntityFrameworkCore;

namespace AbpDemo.Client.Users
{
    public class EfCoreHedouUserRepository : EfCoreUserRepositoryBase<IClientDbContext, HedouUser>, IHedouUserRepository

    {

        public EfCoreHedouUserRepository(IDbContextProvider<IClientDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public virtual async Task<List<HedouUser>> GetUsersAsync(int maxCount, string filter, CancellationToken cancellationToken = default)
        {
            return await this
                .WhereIf(!filter.IsNullOrWhiteSpace(),
                    x => x.UserName.Contains(filter) ||
                        x.Name.Contains(filter) ||
                        x.Email.Contains(filter) ||
                        x.Surname.Contains(filter) ||
                        x.PhoneNumber.Contains(filter)
                    )
                .Take(maxCount)
                .ToListAsync(GetCancellationToken(cancellationToken))
                .ConfigureAwait(false);
        }
    }
}
