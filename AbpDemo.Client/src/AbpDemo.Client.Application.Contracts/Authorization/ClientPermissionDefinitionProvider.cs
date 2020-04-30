using AbpDemo.Client.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpDemo.Client.Authorization
{
    public class ClientPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(ClientPermissions.GroupName, L("Permission:Client"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ClientResource>(name);
        }
    }
}