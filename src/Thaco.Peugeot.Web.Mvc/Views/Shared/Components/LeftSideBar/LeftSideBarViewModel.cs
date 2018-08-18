using Abp.Application.Navigation;

namespace Thaco.Peugeot.Web.Views.Shared.Components.LeftSideBar
{
    public class LeftSideBarViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}
