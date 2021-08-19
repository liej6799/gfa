using gfa_web.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace gfa_web.Permissions
{
    public class gfa_webPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(gfa_webPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(gfa_webPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<gfa_webResource>(name);
        }
    }
}
