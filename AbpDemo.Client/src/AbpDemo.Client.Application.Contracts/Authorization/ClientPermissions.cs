using Volo.Abp.Reflection;

namespace AbpDemo.Client.Authorization
{
    public class ClientPermissions
    {
        public const string GroupName = "Client";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ClientPermissions));
        }
    }
}