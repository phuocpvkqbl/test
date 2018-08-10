using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("News")]
    public class News : FullAuditedEntity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }
        public string Content { get; set; }
        public int VisibilityStatus { get; set; }
        public News()
        {
            VisibilityStatus = 1;

        }
    }
}
