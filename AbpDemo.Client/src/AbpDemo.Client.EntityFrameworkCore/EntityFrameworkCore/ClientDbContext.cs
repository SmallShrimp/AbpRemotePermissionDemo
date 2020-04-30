using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AbpDemo.Client.EntityFrameworkCore
{
    [ConnectionStringName(ClientDbProperties.ConnectionStringName)]
    public class ClientDbContext : AbpDbContext<ClientDbContext>, IClientDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public ClientDbContext(DbContextOptions<ClientDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureClient();
        }
    }
}