using AbpDemo.Client.Users;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace AbpDemo.Client.EntityFrameworkCore
{
    [DependsOn(
        typeof(ClientDomainModule),
        typeof(AbpEntityFrameworkCoreModule),
        typeof(AbpUsersEntityFrameworkCoreModule)
    )]
    public class ClientEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ClientDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });

            context.Services.Replace(ServiceDescriptor.Transient(typeof(IHedouUserRepository), typeof(EfCoreHedouUserRepository)));
        }
    }
}