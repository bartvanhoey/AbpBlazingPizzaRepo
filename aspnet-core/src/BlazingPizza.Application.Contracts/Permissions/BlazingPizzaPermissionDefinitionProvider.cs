using BlazingPizza.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BlazingPizza.Permissions
{
    public class BlazingPizzaPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BlazingPizzaPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(BlazingPizzaPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BlazingPizzaResource>(name);
        }
    }
}
