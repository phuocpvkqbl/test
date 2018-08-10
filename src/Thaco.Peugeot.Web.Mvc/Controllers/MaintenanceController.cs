using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization;
using Thaco.Peugeot.Controllers;
using Thaco.Peugeot.Maintenance;
using Thaco.Peugeot.Web.Models.Maintenance;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class MaintenanceController : PeugeotControllerBase
    {
        private readonly MaintenanceAppService _maintenanceAppService;

        public MaintenanceController(MaintenanceAppService maintenanceAppService)
        {
            _maintenanceAppService = maintenanceAppService;
        }


        public async Task<ActionResult> Index()
        {
            var maintenances = (await _maintenanceAppService.GetAll(new PagedResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            var model = new MaintenanceListViewModel
            {
                Maintenance = maintenances
            };
            return View(model);
        }

        public async Task<ActionResult> EditAppointmentModal(int newsId)
        {
            
            var maintenance = await _maintenanceAppService.Get(new EntityDto<int>(newsId));
            var model = new EditMaintenanceModalViewModel
            {
              Maintenance  = maintenance
            };
            return View("_EditMaintenanceModal", model);
        }
    }
}
