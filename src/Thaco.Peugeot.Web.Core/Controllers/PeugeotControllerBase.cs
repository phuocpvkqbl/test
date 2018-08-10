using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Thaco.Peugeot.Controllers
{
    public abstract class PeugeotControllerBase: AbpController
    {
        protected PeugeotControllerBase()
        {
            LocalizationSourceName = PeugeotConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
