using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.Review.Dto
{
    [AutoMapFrom(typeof(Thaco.Peugeot.Entities.Review))]
    public class ReviewDto : EntityDto
    {
        public const int MaxTitleLength = 250;
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
