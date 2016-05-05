using AspNetCoreConsoleApp.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreConsoleApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;
        
        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }
        
        [HttpGet("/")]
        public IActionResult Index() 
        {
            return View();
        }
    }
}