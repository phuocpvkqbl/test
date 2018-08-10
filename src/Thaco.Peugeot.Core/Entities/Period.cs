using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Period")]
    public class Period : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Code { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Period()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
