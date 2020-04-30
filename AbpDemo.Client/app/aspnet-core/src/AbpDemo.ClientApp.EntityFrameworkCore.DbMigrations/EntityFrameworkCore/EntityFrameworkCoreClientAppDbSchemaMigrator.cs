using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpDemo.ClientApp.Data;
using Volo.Abp.DependencyInjection;

namespace AbpDemo.ClientApp.EntityFrameworkCore
{
    public class EntityFrameworkCoreClientAppDbSchemaMigrator
        : IClientAppDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreClientAppDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ClientAppMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ClientAppMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}