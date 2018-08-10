using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization;
using Thaco.Peugeot.Controllers;
using Thaco.Peugeot.Vehicles;
using Thaco.Peugeot.Web.Models.Vehicle;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class VehicleController : PeugeotControllerBase
    {
        private readonly VehiclesAppService _vehiclesAppService;

        public VehicleController(VehiclesAppService vehiclesAppService)
        {
            _vehiclesAppService = vehiclesAppService;
        }


        public async Task<ActionResult> Index()
        {
            var vehicles = (await _vehiclesAppService.GetAll(new PagedResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            var model = new VehicleListViewModel
            {
                Vehicles = vehicles
            };
            return View(model);
        }

        public async Task<ActionResult> EditNewsModal(int newsId)
        {
            
            var vehicles = await _vehiclesAppService.Get(new EntityDto<int>(newsId));
            var model = new EditVehicleModalViewModel
            {
                Vehicles = vehicles
            };
            return View("_EditVehicleModal", model);
        }
    }
}
