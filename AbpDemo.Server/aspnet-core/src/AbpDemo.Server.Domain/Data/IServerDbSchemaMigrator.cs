using System.Threading.Tasks;

namespace AbpDemo.Server.Data
{
    public interface IServerDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
