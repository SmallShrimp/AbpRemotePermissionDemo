using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AbpDemo.Client.EntityFrameworkCore
{
    [ConnectionStringName(ClientDbProperties.ConnectionStringName)]
    public interface IClientDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}