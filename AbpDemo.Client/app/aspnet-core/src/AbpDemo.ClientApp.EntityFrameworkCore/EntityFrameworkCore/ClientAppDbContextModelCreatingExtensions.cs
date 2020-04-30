using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpDemo.ClientApp.EntityFrameworkCore
{
    public static class ClientAppDbContextModelCreatingExtensions
    {
        public static void ConfigureClientApp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ClientAppConsts.DbTablePrefix + "YourEntities", ClientAppConsts.DbSchema);

            //    //...
            //});
        }
    }
}