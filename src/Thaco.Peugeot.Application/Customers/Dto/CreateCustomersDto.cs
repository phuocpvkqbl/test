﻿using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.Customers.Dto
{
    [AutoMapTo(typeof(Thaco.Peugeot.Entities.Customer))]
   public class CreateCustomersDto
    {
        public string IdentityId { get; set; }
        public const int MaxTitleLength = 250;
        [MaxLength(MaxTitleLength)]
        public string FirstName { get; set; }
        [MaxLength(MaxTitleLength)]
        public string LastName { get; set; }
        [MaxLength(MaxTitleLength)]
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string TaxCode { get; set; }
        public string Website { get; set; }
        //Cá nhân, tổ chức
    }
}