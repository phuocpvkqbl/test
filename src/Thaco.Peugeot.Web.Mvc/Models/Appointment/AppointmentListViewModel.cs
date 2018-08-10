using System.Collections.Generic;
using Thaco.Peugeot.Appointment.Dto;

namespace Thaco.Peugeot.Web.Models.Appointment
{
    public class AppointmentListViewModel
    {
        public IReadOnlyList<AppointmentDto> Appointments { get; set; }
    }
}
