using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Document")]
    public class Document : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int PeriodId { get; set; }

        [MaxLength(MaxTitleLength)]
        public string Name { get; set; }
        public int Engine { get; set; }
        public int HeatingAirConditioning { get; set; }
        public int Gearbox { get; set; }
        public int AudioSystem { get; set; }
        public int VisibilityStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public Document()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
