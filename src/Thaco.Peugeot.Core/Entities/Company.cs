using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Company")]
    public class Company:Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        [MaxLength(MaxTitleLength)]
        public string CompanyName { get; set; }
        [MaxLength(MaxTitleLength)]
        public string CompanyEmail { get; set; }
        [MaxLength(MaxTitleLength)]
        public string CompanyLogo { get; set; }
        [MaxLength(MaxTitleLength)]
        public string CompanyPhone { get; set; }
        [MaxLength(MaxTitleLength)]
        public string CompanyWebsite { get; set; }
        [MaxLength(MaxTitleLength)]
        public string CompanyAddress { get; set; }
        [MaxLength(MaxTitleLength)]
        public string CompanyCity { get; set; }
        [MaxLength(MaxTitleLength)]
        public string CompanyDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public double LocationLat { get; set; }
        public double LocationLng { get; set; }
        public int Type { get; set; }
        public int VisibilityStatus { get; set; }
        public Company()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
