using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization;
using Thaco.Peugeot.City;
using Thaco.Peugeot.City.Dto;
using Thaco.Peugeot.Controllers;
using Thaco.Peugeot.Customers;
using Thaco.Peugeot.District;
using Thaco.Peugeot.News;
using Thaco.Peugeot.Ward;
using Thaco.Peugeot.Web.Models.Customer;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class CustomerController : PeugeotControllerBase
    {
        private readonly CustomerAppService _customerAppService;
        private readonly CityAppService _cityAppService;
        private readonly DistrictAppService _districtAppService;
        private readonly WardAppService _wardAppService;

        public CustomerController(CustomerAppService customerAppService,CityAppService cityAppService,
            DistrictAppService districtAppService,WardAppService wardAppService)
        {
            _customerAppService = customerAppService;
            _cityAppService = cityAppService;
            _districtAppService = districtAppService;
            _wardAppService = wardAppService;
        }


        public async Task<ActionResult> Index()
        {
            var customers = (await _customerAppService.GetAll(new PagedResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            var cities = (await _cityAppService.GetAll(new PagedResultRequestDto { MaxResultCount = int.MaxValue })).Items;
            //var districts = (await _districtAppService.GetAllDistrictsWithCity()).Items;
           // var wards = (await _wardAppService.GetAll(new PagedResultRequestDto { MaxResultCount = int.MaxValue })).Items;
            var model = new CustomerListViewModel
            {
                Customer = customers,
                Cities = cities
            };
            return View(model);
        }

        public async Task<ActionResult> EditCustomerModal(int customerId)
        {
            
            var customer = await _customerAppService.Get(new EntityDto<int>(customerId));
            var model = new EditCustomerModalViewModel
            {
                Customer = customer
            };
            return View("_EditCustomerModal", model);
        }
    }
}
