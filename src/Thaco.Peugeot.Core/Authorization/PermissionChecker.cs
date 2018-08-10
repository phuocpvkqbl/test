using Abp.Authorization;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;

namespace Thaco.Peugeot.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
