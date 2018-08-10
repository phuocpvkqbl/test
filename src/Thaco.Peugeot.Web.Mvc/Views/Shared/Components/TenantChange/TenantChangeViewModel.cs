using Abp.AutoMapper;
using Thaco.Peugeot.Sessions.Dto;

namespace Thaco.Peugeot.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
