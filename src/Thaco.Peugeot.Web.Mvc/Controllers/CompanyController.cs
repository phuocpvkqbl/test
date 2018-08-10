using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization;
using Thaco.Peugeot.Controllers;
using Thaco.Peugeot.Company;
using Thaco.Peugeot.Web.Models.Company;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class CompanyController : PeugeotControllerBase
    {
        private readonly CompanyAppService _companyAppService;

        public CompanyController(CompanyAppService companyAppService)
        {
            _companyAppService = companyAppService;
        }


        public async Task<ActionResult> Index()
        {
            var companies = (await _companyAppService.GetAll(new PagedResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            var model = new CompanyListViewModel
            {
                Companies = companies
            };
            return View(model);
        }

        public async Task<ActionResult> EditNewsModal(int newsId)
        {
            
            var company = await _companyAppService.Get(new EntityDto<int>(newsId));
            var model = new EditCompanyModalViewModel
            {
                Company = company
            };
            return View("_EditCompanyModal", model);
        }
    }
}
