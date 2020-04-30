using System.Threading.Tasks;

namespace AbpDemo.ClientApp.Data
{
    public interface IClientAppDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
