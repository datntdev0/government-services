using Abp.Authorization;
using Government.Services.Authorization.Roles;
using Government.Services.Authorization.Users;

namespace Government.Services.Authorization.Permissions
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

