using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Customer")]
    public class Customer : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public string IdentityId { get; set; }
        [MaxLength(MaxTitleLength)]
        public string FirstName { get; set; }
        [MaxLength(MaxTitleLength)]
        public string LastName { get; set; }
        public int VisibilityStatus { get; set; }
        [MaxLength(MaxTitleLength)]
        public string OfficePhoneNumber { get; set; }
        [MaxLength(MaxTitleLength)]
        public string MobileNumber { get; set; }
        [MaxLength(MaxTitleLength)]
        public string HomePhoneNumber { get; set; }
        public string Note { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Email { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Address { get; set; }
        [MaxLength(MaxTitleLength)]
        public string City { get; set; }
        public string District { get; set; }
        public string ProfileImage { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Password { get; set; }
        public string Description { get; set; }
        public string TaxCode { get; set; }
        public string Website { get; set; }
        //Cá nhân, tổ chức
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
        [Column(TypeName ="Date")]
        public DateTime Birthday { get; set; }
        public Customer()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
