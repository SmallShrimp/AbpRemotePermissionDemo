using AbpDemo.Client.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpDemo.Client
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(ClientEntityFrameworkCoreTestModule)
        )]
    public class ClientDomainTestModule : AbpModule
    {
        
    }
}
