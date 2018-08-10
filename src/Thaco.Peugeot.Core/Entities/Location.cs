using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Entities
{
    [Table("Location")]
    public class Location : Entity
    {
        public const int MaxTitleLength = 250;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        public int ParentId { get; set; }
        [MaxLength(MaxTitleLength)]
        public string Name { get; set; }
        //1-quoc gia, 2-tp/tinh, 3-Quan/huyen/TP tinh ly, 4-Phuong/Xa/TTran, 5-Thon/Ap
        public int Type { get; set; }
    }
}
