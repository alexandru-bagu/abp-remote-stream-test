using RemoteStream.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RemoteStream.Permissions
{
    public class RemoteStreamPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(RemoteStreamPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(RemoteStreamPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<RemoteStreamResource>(name);
        }
    }
}
