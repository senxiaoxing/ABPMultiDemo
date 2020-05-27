using Abp.Authorization;
using MyABPSite.Authorization.Roles;
using MyABPSite.Authorization.Users;

namespace MyABPSite.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
