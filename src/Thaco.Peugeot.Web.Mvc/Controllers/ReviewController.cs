using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization;
using Thaco.Peugeot.Controllers;
using Thaco.Peugeot.Review;
using Thaco.Peugeot.Web.Models.Review;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class ReviewController : PeugeotControllerBase
    {
        private readonly ReviewAppService _reviewAppService;

        public ReviewController(ReviewAppService reviewAppService)
        {
            _reviewAppService = reviewAppService;
        }


        public async Task<ActionResult> Index()
        {
            var reviews = (await _reviewAppService.GetAll(new PagedResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            var model = new ReviewListViewModel
            {
                Reviews = reviews
            };
            return View(model);
        }

        public async Task<ActionResult> EditAppointmentModal(int reviewId)
        {
            
            var review = await _reviewAppService.Get(new EntityDto<int>(reviewId));
            var model = new EditReviewModalViewModel
            {
              Review  = review
            };
            return View("_EditReviewModal", model);
        }
    }
}
