using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.Notification.Dto
{
    [AutoMapFrom(typeof(Thaco.Peugeot.Entities.Notification))]
    public class NotificationDto : EntityDto
    {
        public const int MaxTitleLength = 250;
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
