using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Navigation;
using Abp.Runtime.Session;

namespace Thaco.Peugeot.Web.Views.Shared.Components.LeftSideBar
{
    public class LeftSideBarViewComponent : PeugeotViewComponent
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly IAbpSession _abpSession;

        public LeftSideBarViewComponent(
            IUserNavigationManager userNavigationManager,
            IAbpSession abpSession)
        {
            _userNavigationManager = userNavigationManager;
            _abpSession = abpSession;
        }

        public async Task<IViewComponentResult> InvokeAsync(string activeMenu = "")
        {
            var model = new LeftSideBarViewModel
            {
                MainMenu = await _userNavigationManager.GetMenuAsync("MainMenu", _abpSession.ToUserIdentifier()),
                ActiveMenuItemName = activeMenu
            };

            return View(model);
        }
    }
}
