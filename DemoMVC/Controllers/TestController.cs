using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Abc()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
