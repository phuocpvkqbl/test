using Abp.Application.Navigation;
using Abp.Localization;
using Thaco.Peugeot.Authorization;

namespace Thaco.Peugeot.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class PeugeotNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fa-home",
                        requiresAuthentication: true
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "fa-user-circle",
                        requiredPermissionName: PermissionNames.Pages_Users
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "fa-tasks",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.News,
                        L("News"),
                        url: "News",
                        icon: "fa-newspaper-o",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Notification,
                        L("Notification"),
                        url: "Notification",
                        icon: "fa-bell",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Vehicles,
                        L("Vehicles"),
                        url: "Vehicles",
                        icon: "fa-car",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Customers,
                        L("Customer"),
                        url: "Customer",
                        icon: "fa-user-circle",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Company,
                        L("Company"),
                        url: "Company",
                        icon: "fa-building-o",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Document,
                        L("Document"),
                        url: "Document",
                        icon: "fa-file-o",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, PeugeotConsts.LocalizationSourceName);
        }
    }
}
