using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace AbpDemo.Client.MongoDB
{
    [DependsOn(
        typeof(ClientTestBaseModule),
        typeof(ClientMongoDbModule)
        )]
    public class ClientMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionString = MongoDbFixture.ConnectionString.EnsureEndsWith('/') +
                                   "Db_" +
                                    Guid.NewGuid().ToString("N");

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}