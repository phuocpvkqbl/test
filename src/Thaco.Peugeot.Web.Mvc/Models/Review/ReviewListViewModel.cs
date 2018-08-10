using System.Collections.Generic;
using Thaco.Peugeot.Review.Dto;

namespace Thaco.Peugeot.Web.Models.Review
{
    public class ReviewListViewModel
    {
        public IReadOnlyList<ReviewDto> Reviews { get; set; }
    }
}
