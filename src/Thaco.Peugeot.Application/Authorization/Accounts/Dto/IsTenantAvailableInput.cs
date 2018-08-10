using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace Thaco.Peugeot.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}
