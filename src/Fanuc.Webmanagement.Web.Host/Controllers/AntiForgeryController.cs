using Microsoft.AspNetCore.Antiforgery;
using Fanuc.Webmanagement.Controllers;

namespace Fanuc.Webmanagement.Web.Host.Controllers
{
    public class AntiForgeryController : WebmanagementControllerBase
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
