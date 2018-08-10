using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("DocumentGroup")]
    public class DocumentGroup : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public int DocumentId { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Detail { get; set; }
        public int VisibilityStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DocumentGroup()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
