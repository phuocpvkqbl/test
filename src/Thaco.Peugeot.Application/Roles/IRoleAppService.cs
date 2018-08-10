using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Thaco.Peugeot.Roles.Dto;

namespace Thaco.Peugeot.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
