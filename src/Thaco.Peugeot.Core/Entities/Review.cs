using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Review")]
    public class Review : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public int CompanyId { get; set; }
        public int CustomerId { get; set; }
        [MaxLength(MaxTitleLength)]
        public string ReviewProviderName { get; set; }
        [MaxLength(MaxTitleLength)]
        public string ReviewEmail { get; set; }
        [MaxLength(MaxTitleLength)]
        public string ReviewDetail { get; set; }
        public int Rating { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedDate1 { get; set; }
        public Review()
        {
            CreatedDate = DateTime.Now;
            CreatedDate1 = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
        }
    }
}
