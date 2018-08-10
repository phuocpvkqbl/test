using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.District.Dto
{
    [AutoMapFrom(typeof(Thaco.Peugeot.Entities.District))]
    public class DistrictDto:EntityDto
    {
        public const int MaxTitleLength = 250;
        public int CityId { get; set; }
        public string CityCode { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Code { get; set; }
        public string Name { get; set; }
        public double? LocationLat { get; set; }
        public double? LocationLng { get; set; }
        public string URL { get; set; }
    }
}
