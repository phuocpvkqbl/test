using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Model")]
    public class Model : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public int BrandId { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Code { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Name { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public Model()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
