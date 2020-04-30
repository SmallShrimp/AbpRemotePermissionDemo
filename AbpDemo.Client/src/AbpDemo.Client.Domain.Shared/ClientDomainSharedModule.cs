using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using AbpDemo.Client.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace AbpDemo.Client
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class ClientDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<ClientDomainSharedModule>("AbpDemo.Client");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<ClientResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Client");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("Client", typeof(ClientResource));
            });
        }
    }
}
