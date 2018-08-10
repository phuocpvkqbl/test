using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.News.Dto
{
    [AutoMapFrom(typeof(Thaco.Peugeot.Entities.News))]
    public class NewsDto:EntityDto
    {
        public const int MaxTitleLength = 250;
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
