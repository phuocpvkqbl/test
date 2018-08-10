using System.Collections.Generic;
using Thaco.Peugeot.Roles.Dto;

namespace Thaco.Peugeot.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
