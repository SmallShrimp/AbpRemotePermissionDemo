using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Users;

namespace AbpDemo.Client.Users
{
    public interface IHedouUserRepository
        : IBasicRepository<HedouUser, Guid>, IUserRepository<HedouUser>
    {
        Task<List<HedouUser>> GetUsersAsync(int maxCount, string filter, CancellationToken cancellationToken = default);
    }
}
