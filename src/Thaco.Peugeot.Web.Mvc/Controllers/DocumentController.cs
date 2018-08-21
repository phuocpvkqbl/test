using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thaco.Peugeot.Authorization;
using Thaco.Peugeot.Controllers;
using Thaco.Peugeot.Document;
using Thaco.Peugeot.Web.Models.Document;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class DocumentController : PeugeotControllerBase
    {
        private readonly DocumentAppService _documentAppService;

        public DocumentController(DocumentAppService documentAppService)
        {
            _documentAppService = documentAppService;
        }


        public async Task<ActionResult> Index()
        {
            var documents = (await _documentAppService.GetAll(new PagedResultRequestDto {MaxResultCount = int.MaxValue})).Items; // Paging not implemented yet
            var model = new DocumentListViewModel
            {
                Documents = documents
            };
            return View(model);
        }

        public async Task<ActionResult> Insert()
        {
            return View();
        }

        public async Task<ActionResult> EditAppointmentModal(int newsId)
        {
            
            var document = await _documentAppService.Get(new EntityDto<int>(newsId));
            var model = new EditDocumentModalViewModel
            {
              Document  = document
            };
            return View("_EditDocumentModal", model);
        }
    }
}
