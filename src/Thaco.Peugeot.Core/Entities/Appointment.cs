using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Appointment")]
    public class Appointment:Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        [MaxLength(MaxTitleLength)]
        public string BookingNumber { get; set; }
        public int CompanyId { get; set; }
        public int CustomerId { get; set; }
        [MaxLength(MaxTitleLength)]
        public string CustomerName { get; set; }
        [MaxLength(MaxTitleLength)]
        public string CustomerPhone { get; set; }
        public int VehicleId { get; set; }
        public int PackageId { get; set; }
        [MaxLength(MaxTitleLength)]
        public string PackageName { get; set; }
        public int PackageTime { get; set; }
        public Decimal PackageBalance { get; set; }
        public int CurrentKm { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentEndDate { get; set; }
        public int BookingFrom { get; set; }
        public Decimal TotalAmount { get; set; }
        public int PaymentStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public Appointment()
        {
            CreatedDate = DateTime.Now;
        }

    }
}
