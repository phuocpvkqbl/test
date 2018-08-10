using Microsoft.AspNetCore.Antiforgery;
using Thaco.Peugeot.Controllers;

namespace Thaco.Peugeot.Web.Host.Controllers
{
    public class AntiForgeryController : PeugeotControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
