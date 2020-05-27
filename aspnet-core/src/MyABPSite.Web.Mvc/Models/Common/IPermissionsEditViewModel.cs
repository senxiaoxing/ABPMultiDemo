using System.Collections.Generic;
using MyABPSite.Roles.Dto;

namespace MyABPSite.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}