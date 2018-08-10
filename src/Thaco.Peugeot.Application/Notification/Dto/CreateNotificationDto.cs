using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.Notification.Dto
{
    [AutoMapTo(typeof(Thaco.Peugeot.Entities.Notification))]
   public class CreateNotificationDto
    {
        public const int MaxTitleLength = 250;
        [StringLength(MaxTitleLength)]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public int VisibilityStatus { get; set; }
    }
}