using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpDemo.ClientApp.Data
{
    /* This is used if database provider does't define
     * IClientAppDbSchemaMigrator implementation.
     */
    public class NullClientAppDbSchemaMigrator : IClientAppDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}