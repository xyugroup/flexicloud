using Abp.Authorization;
using FlexiCloudPay.Authorization.Roles;
using FlexiCloudPay.Authorization.Users;

namespace FlexiCloudPay.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
