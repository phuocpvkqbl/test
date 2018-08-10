using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Role")]
    public class Role : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        [MaxLength(MaxTitleLength)]
        public string Name { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public Role()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
