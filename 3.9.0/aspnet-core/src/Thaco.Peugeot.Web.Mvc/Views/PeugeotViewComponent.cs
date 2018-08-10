using Abp.AspNetCore.Mvc.ViewComponents;

namespace Thaco.Peugeot.Web.Views
{
    public abstract class PeugeotViewComponent : AbpViewComponent
    {
        protected PeugeotViewComponent()
        {
            LocalizationSourceName = PeugeotConsts.LocalizationSourceName;
        }
    }
}
