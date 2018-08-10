using System.Collections.Generic;
using Thaco.Peugeot.Maintenance.Dto;

namespace Thaco.Peugeot.Web.Models.Maintenance
{ 
    public class MaintenanceListViewModel
    {
        public IReadOnlyList<MaintenanceDto> Maintenance { get; set; }
    }
}
