using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.City.Dto
{
    [AutoMapFrom(typeof(Thaco.Peugeot.Entities.City))]
    public class CityDto : EntityDto
    {
        public const int MaxTitleLength = 250;
        [MaxLength(MaxTitleLength)]
        public string Code { get; set; }
        public string Name { get; set; }
        public double? LocationLat { get; set; }
        public double? LocationLng { get; set; }
        public string URL { get; set; }
    }
}
