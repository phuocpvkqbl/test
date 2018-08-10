using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization;
using Thaco.Peugeot.Controllers;
using Thaco.Peugeot.Appointment;
using Thaco.Peugeot.Web.Models.Appointment;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class AppointmentController : PeugeotControllerBase
    {
        private readonly AppointmentAppService _appointmentAppService;

        public AppointmentController(AppointmentAppService appointmentAppService)
        {
            _appointmentAppService = appointmentAppService;
        }


        public async Task<ActionResult> Index()
        {
            var appointments = (await _appointmentAppService.GetAll(new PagedResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            var model = new AppointmentListViewModel
            {
                Appointments = appointments
            };
            return View(model);
        }

        public async Task<ActionResult> EditAppointmentModal(int newsId)
        {
            
            var appointment = await _appointmentAppService.Get(new EntityDto<int>(newsId));
            var model = new EditAppointmentModalViewModel
            {
                Appointment = appointment
            };
            return View("_EditAppointmentModal", model);
        }
    }
}
