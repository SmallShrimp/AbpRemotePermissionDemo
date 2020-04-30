using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace AbpDemo.Client.MongoDB
{
    public class ClientMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public ClientMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}