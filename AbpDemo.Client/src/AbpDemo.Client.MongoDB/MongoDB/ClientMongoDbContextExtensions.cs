using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace AbpDemo.Client.MongoDB
{
    public static class ClientMongoDbContextExtensions
    {
        public static void ConfigureClient(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ClientMongoModelBuilderConfigurationOptions(
                ClientDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}