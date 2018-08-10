using System.Collections.Generic;
using Thaco.Peugeot.News.Dto;

namespace Thaco.Peugeot.Web.Models.News
{
    public class NewsListViewModel
    {
        public IReadOnlyList<NewsDto> News { get; set; }
    }
}