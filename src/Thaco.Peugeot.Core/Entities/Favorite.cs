using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Favorite")]
    public class Favorite : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public int CustomerId { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Favorite()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
