using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.Vehicles.Dto
{
    [AutoMapTo(typeof(Thaco.Peugeot.Entities.Vehicle))]
   public class CreateVehiclesDto
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