using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreConsoleApp.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View();
    }
}