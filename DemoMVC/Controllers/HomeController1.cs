using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
