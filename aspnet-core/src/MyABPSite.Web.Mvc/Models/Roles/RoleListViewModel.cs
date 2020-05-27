using System.Collections.Generic;
using MyABPSite.Roles.Dto;

namespace MyABPSite.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
