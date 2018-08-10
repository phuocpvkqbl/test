using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Vehicle")]
    public class Vehicle : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int PeriodId { get; set; }
        [MaxLength(MaxTitleLength)]
        public string VinCode { get; set; }
        [MaxLength(MaxTitleLength)]
        public string CarNumber { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Description { get; set; }
        public int Year { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Color { get; set; }
        public int Engine { get; set; }
        public int MileageId { get; set; }
        public int CurrentKm { get; set; }
        public int Monthofuse { get; set; }
        public DateTime CreatedDate { get; set; }
        public Vehicle()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
