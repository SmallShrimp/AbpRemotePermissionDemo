using System;
using AbpDemo.Client.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;

namespace AbpDemo.Client.EntityFrameworkCore
{
    public static class ClientDbContextModelCreatingExtensions
    {
        public static void ConfigureClient(
            this ModelBuilder builder,
            Action<ClientModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ClientModelBuilderConfigurationOptions(
                ClientDbProperties.DbTablePrefix,
                ClientDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);


            builder.Entity<HedouUser>(b =>
            {
                b.ToTable(options.TablePrefix + "HedouUser", null);
                b.ConfigureAbpUser();
                b.ConfigureExtraProperties();
            });

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}