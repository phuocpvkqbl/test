using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization;
using Thaco.Peugeot.Controllers;
using Thaco.Peugeot.News;
using Thaco.Peugeot.Web.Models.News;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class NewsController : PeugeotControllerBase
    {
        private readonly NewsAppService _newAppService;

        public NewsController(NewsAppService newAppService)
        {
            _newAppService = newAppService;
        }


        public async Task<ActionResult> Index()
        {
            var news = (await _newAppService.GetAll(new PagedResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            var model = new NewsListViewModel
            {
                News = news
            };
            return View(model);
        }

        public async Task<ActionResult> EditNewsModal(int newsId)
        {
            
            var news = await _newAppService.Get(new EntityDto<int>(newsId));
            var model = new EditNewsModalViewModel
            {
                News = news
            };
            return View("_EditNewsModal", model);
        }
    }
}
