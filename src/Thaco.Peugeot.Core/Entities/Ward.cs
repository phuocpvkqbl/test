using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Ward")]
    public class Ward : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
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
