using System.Collections.Generic;
using Thaco.Peugeot.Roles.Dto;
using Thaco.Peugeot.Customers.Dto;
using Thaco.Peugeot.City.Dto;
using Thaco.Peugeot.District.Dto;
using Thaco.Peugeot.Ward.Dto;

namespace Thaco.Peugeot.Web.Models.Customer
{
    public class CustomerListViewModel
    {
        public IReadOnlyList<CustomerDto> Customer { get; set; }
        public IReadOnlyList<CityDto> Cities { get; set; }
        public IReadOnlyList<DistrictDto> Districts { get; set; }
        public IReadOnlyList<WardDto> Wards { get; set; }

    }
}
