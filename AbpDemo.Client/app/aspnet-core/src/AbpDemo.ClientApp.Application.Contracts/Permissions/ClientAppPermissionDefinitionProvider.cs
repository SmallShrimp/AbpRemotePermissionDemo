using AbpDemo.ClientApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpDemo.ClientApp.Permissions
{
    public class ClientAppPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ClientAppPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ClientAppPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ClientAppResource>(name);
        }
    }
}
