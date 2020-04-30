using Volo.Abp.Settings;

namespace AbpDemo.ClientApp.Settings
{
    public class ClientAppSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ClientAppSettings.MySetting1));
        }
    }
}
