using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization;
using Thaco.Peugeot.City;
using Thaco.Peugeot.City.Dto;
using Thaco.Peugeot.Controllers;
using Thaco.Peugeot.Customers;
using Thaco.Peugeot.District;
using Thaco.Peugeot.District.Dto;
using Thaco.Peugeot.News;
using Thaco.Peugeot.Ward;
using Thaco.Peugeot.Web.Models.Customer;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class DistrictController : PeugeotControllerBase
    {
        private readonly DistrictAppService _districtAppService;

        public DistrictController(DistrictAppService districtAppService)
        {
            _districtAppService = districtAppService;
        }

        [HttpGet]
        public ActionResult GetAllDistrictsWithCity(int? cityId)
        {
           // var districts =  _districtAppService.GetAllDistrictsWithCity(cityId).Result.Items;
            IEnumerable<DistrictDto> a = new List<DistrictDto>()
            {
                new DistrictDto
                {
                    Id =1,Name="1"
                },
                new DistrictDto
                {
                    Id =2,Name="2"
                },
                new DistrictDto
                {
                    Id =3,Name="3"
                }
            };
            return Json(a);
        }
    }
}
