using qa657.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace qa657.Permissions
{
    public class qa657PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(qa657Permissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(qa657Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<qa657Resource>(name);
        }
    }
}
