using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AbpDemo.Client.MongoDB
{
    [ConnectionStringName(ClientDbProperties.ConnectionStringName)]
    public interface IClientMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
