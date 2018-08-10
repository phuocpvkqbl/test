using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Package")]
    public class Package : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        [MaxLength(MaxTitleLength)]
        public string Code { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int TotalTime { get; set; }
        public Decimal TienCong { get; set; }
        public Decimal TienVatTu { get; set; }
        public Decimal TienKhac { get; set; }
        public Decimal? TotalAmount { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Description { get; set; }
        public int VisibilityStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public Package()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
