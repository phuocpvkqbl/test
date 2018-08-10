using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Thaco.Peugeot.Web.Views
{
    public abstract class PeugeotRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PeugeotRazorPage()
        {
            LocalizationSourceName = PeugeotConsts.LocalizationSourceName;
        }
    }
}
