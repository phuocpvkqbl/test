using System.Collections.Generic;
using Thaco.Peugeot.Vehicles.Dto;

namespace Thaco.Peugeot.Web.Models.Vehicle
{ 
    public class VehicleListViewModel
    {
        public IReadOnlyList<VehiclesDto> Vehicles { get; set; }
    }
}
