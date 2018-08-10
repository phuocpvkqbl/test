using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("DocumentDetail")]
    public class DocumentDetail : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public int DocumentId { get; set; }
        public int DocumentGroupId { get; set; }
        
        [MaxLength(MaxTitleLength)]
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Detail { get; set; }
        public int Type { get; set; }
        public int VisibilityStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DocumentDetail()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
