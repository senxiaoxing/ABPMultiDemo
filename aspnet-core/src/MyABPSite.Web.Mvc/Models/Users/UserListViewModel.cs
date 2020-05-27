using System.Collections.Generic;
using MyABPSite.Roles.Dto;

namespace MyABPSite.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
