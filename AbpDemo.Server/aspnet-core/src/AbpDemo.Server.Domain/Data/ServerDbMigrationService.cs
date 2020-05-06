﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;
using Volo.Abp.TenantManagement;

namespace AbpDemo.Server.Data
{
    public class ServerDbMigrationService : ITransientDependency
    {
        public ILogger<ServerDbMigrationService> Logger { get; set; }

        private readonly IDataSeeder _dataSeeder;
        private readonly IEnumerable<IServerDbSchemaMigrator> _dbSchemaMigrators;
        private readonly ITenantRepository _tenantRepository;
        private readonly ICurrentTenant _currentTenant;

        public ServerDbMigrationService(
            IDataSeeder dataSeeder,
            IEnumerable<IServerDbSchemaMigrator> dbSchemaMigrators,
            ITenantRepository tenantRepository,
            ICurrentTenant currentTenant)
        {
            _dataSeeder = dataSeeder;
            _dbSchemaMigrators = dbSchemaMigrators;
            _tenantRepository = tenantRepository;
            _currentTenant = currentTenant;

            Logger = NullLogger<ServerDbMigrationService>.Instance;
        }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");

            await MigrateHostDatabaseAsync();

            var tenants = await _tenantRepository.GetListAsync(includeDetails: true);

            var i = 0;
            foreach (var tenant in tenants.Where(t => t.ConnectionStrings.Any()))
            {
                using (_currentTenant.Change(tenant.Id))
                {
                    Logger.LogInformation($"Migrating {tenant.Name} database schema... ({++i} of {tenants.Count})");
                    await MigrateTenantDatabasesAsync(tenant);
                    Logger.LogInformation($"Successfully completed {tenant.Name} database migrations.");
                }
            }

            Logger.LogInformation("Successfully completed database migrations.");
        }

        private async Task MigrateHostDatabaseAsync()
        {
            Logger.LogInformation("Migrating host database schema...");

            foreach (var migrator in _dbSchemaMigrators)
            {
                await migrator.MigrateAsync();
            }

            Logger.LogInformation("Executing host database seed...");
            await _dataSeeder.SeedAsync();

            Logger.LogInformation("Successfully completed host database migrations.");
        }

        private async Task MigrateTenantDatabasesAsync(Tenant tenant)
        {
            Logger.LogInformation($"Migrating schema for {tenant.Name} database...");

            foreach (var migrator in _dbSchemaMigrators)
            {
                await migrator.MigrateAsync();
            }

            Logger.LogInformation($"Executing {tenant.Name} tenant database seed...");
            
            await _dataSeeder.SeedAsync(tenant.Id);
        }
    }
}