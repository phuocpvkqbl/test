using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Maintenance")]
    public class Maintenance : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public int CustomerId { get; set; }
        public int VerhicleId { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public int FromKm { get; set; }
        public int ToKm { get; set; }
        public string Detail { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public Maintenance()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
