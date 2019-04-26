using Abp.Authorization;
using Fanuc.Webmanagement.Authorization.Roles;
using Fanuc.Webmanagement.Authorization.Users;

namespace Fanuc.Webmanagement.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
