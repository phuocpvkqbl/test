using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization;
using Thaco.Peugeot.Controllers;
using Thaco.Peugeot.Notification;
using Thaco.Peugeot.Web.Models.Notification;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class NotificationController : PeugeotControllerBase
    {
        private readonly NotificationAppService _notificationAppService;

        public NotificationController(NotificationAppService notificationAppService)
        {
            _notificationAppService = notificationAppService;
        }


        public async Task<ActionResult> Index()
        {
            var notifications = (await _notificationAppService.GetAll(new PagedResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            var model = new NotificationListViewModel
            {
                Notifications = notifications
            };
            return View(model);
        }

        public async Task<ActionResult> EditAppointmentModal(int reviewId)
        {
            
            var notification = await _notificationAppService.Get(new EntityDto<int>(reviewId));
            var model = new EditNotificationModalViewModel
            {
              Notification  = notification
            };
            return View("_EditNotificationModal", model);
        }
    }
}
