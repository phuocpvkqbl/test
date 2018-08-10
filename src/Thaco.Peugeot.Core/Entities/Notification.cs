using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Notification")]
    public class Notification : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        [MaxLength(MaxTitleLength)]
        [Column("Title")]
        public string Title { get; set; }
        [Column("Content")]

        public string Content { get; set; }
        [Column("VisibilityStatus")]
        public int VisibilityStatus { get; set; }
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        public Notification()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
