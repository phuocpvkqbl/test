using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization;
using Thaco.Peugeot.Controllers;
using Thaco.Peugeot.Customers;
using Thaco.Peugeot.News;
using Thaco.Peugeot.Vehicles;
using Thaco.Peugeot.Web.Models.News;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class VehiclesController : PeugeotControllerBase
    {
        private readonly VehiclesAppService _vehiclesAppService;

        public VehiclesController(VehiclesAppService vehiclesAppService)
        {
            _vehiclesAppService = vehiclesAppService;
        }


        public async Task<ActionResult> Index()
        {
            var news = (await _vehiclesAppService.GetAll(new PagedResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            var model = new NewsListViewModel
            {
               // News = news
            };
            return View(model);
        }

        public async Task<ActionResult> EditNewsModal(int newsId)
        {
            
            var news = await _vehiclesAppService.Get(new EntityDto<int>(newsId));
            var model = new EditNewsModalViewModel
            {
                //News = news
            };
            return View("_EditNewsModal", model);
        }
    }
}
