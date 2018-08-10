using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thaco.Peugeot.Customers.Dto
{
    [AutoMapFrom(typeof(Thaco.Peugeot.Entities.Customer))]
    public class CustomerDto:EntityDto
    {
        public string IdentityId { get; set; }
        public const int MaxTitleLength = 250;
        [MaxLength(MaxTitleLength)]        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [MaxLength(MaxTitleLength)]
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string TaxCode { get; set; }
        public string Website { get; set; }
        public DateTime CreatedDate { get; set; }
        //Cá nhân, tổ chức
        public string Type { get; set; }
        public DateTime Birthday { get; set; }
    }
}
