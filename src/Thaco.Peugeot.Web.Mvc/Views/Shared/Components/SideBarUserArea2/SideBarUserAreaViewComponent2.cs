using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Configuration.Startup;
using Thaco.Peugeot.Sessions;

namespace Thaco.Peugeot.Web.Views.Shared.Components.SideBarUserArea2
{
    public class SideBarUserAreaViewComponent2 : PeugeotViewComponent
    {
        private readonly ISessionAppService _sessionAppService;
        private readonly IMultiTenancyConfig _multiTenancyConfig;

        public SideBarUserAreaViewComponent2(ISessionAppService sessionAppService,
            IMultiTenancyConfig multiTenancyConfig)
        {
            _sessionAppService = sessionAppService;
            _multiTenancyConfig = multiTenancyConfig;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new SideBarUserAreaViewModel2
            {
                LoginInformations = await _sessionAppService.GetCurrentLoginInformations(),
                IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled,
            };

            return View(model);
        }
    }
}
