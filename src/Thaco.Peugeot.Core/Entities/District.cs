using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("District")]
    public class District : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
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
