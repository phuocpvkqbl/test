using System.Collections.Generic;
using Thaco.Peugeot.Roles.Dto;
using Thaco.Peugeot.Users.Dto;

namespace Thaco.Peugeot.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
