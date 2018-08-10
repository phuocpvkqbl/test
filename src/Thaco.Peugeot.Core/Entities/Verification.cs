using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Thaco.Peugeot.Entities
{
    [Table("Verification")]
    public class Verification:Entity
    {
       
        public int CustomerId { get; set; }
        public string Code { get; set; }
        public Boolean CodeStatus => false;
    }
}
