using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.Ward.Dto
{
    [AutoMapFrom(typeof(Thaco.Peugeot.Entities.Ward))]
    public class WardDto:EntityDto
    {
        public const int MaxTitleLength = 250;
        public int DistrictId { get; set; }
        public string DistrictCode { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Code { get; set; }
        public string Name { get; set; }
        public double? LocationLat { get; set; }
        public double? LocationLng { get; set; }
        public string URL { get; set; }
    }
}
