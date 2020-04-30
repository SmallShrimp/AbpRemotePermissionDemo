using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AbpDemo.Client.EntityFrameworkCore
{
    public class ClientModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ClientModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}