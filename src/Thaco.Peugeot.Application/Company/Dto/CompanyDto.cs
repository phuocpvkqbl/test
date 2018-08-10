using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.Company.Dto
{
    [AutoMapFrom(typeof(Thaco.Peugeot.Entities.Company))]
    public class CompanyDto : EntityDto
    {
        public const int MaxTitleLength = 250;
        [MaxLength(MaxTitleLength)]
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyCity { get; set; }

    }
}
