using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("User")]
    public class User : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public int CompanyId { get; set; }

        [MaxLength(MaxTitleLength)]
        public string Firstname { get; set; }
        [MaxLength(MaxTitleLength)]
        public string LastName { get; set; }
        [MaxLength(MaxTitleLength)]
        public string UserType { get; set; }
        [MaxLength(MaxTitleLength)]
        public string UserPhotoFile { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Email { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Password { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Mobile { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Description { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Address { get; set; }
        public int VisibilityStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public User()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
