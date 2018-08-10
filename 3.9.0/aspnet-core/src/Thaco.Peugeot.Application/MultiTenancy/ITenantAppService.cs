using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Thaco.Peugeot.MultiTenancy.Dto;

namespace Thaco.Peugeot.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
