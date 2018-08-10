using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Event")]
    public class Event : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
      
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Location { get; set; }
        public string Content { get; set; }
        public DateTime Postdate { get; set; }
        public int VisibilityStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public Event()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
