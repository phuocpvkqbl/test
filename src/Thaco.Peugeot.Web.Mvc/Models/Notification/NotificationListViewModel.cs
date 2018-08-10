using System.Collections.Generic;
using Thaco.Peugeot.Notification.Dto;

namespace Thaco.Peugeot.Web.Models.Notification
{
    public class NotificationListViewModel
    {
        public IReadOnlyList<NotificationDto> Notifications { get; set; }
    }
}
