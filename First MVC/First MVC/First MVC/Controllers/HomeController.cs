using Microsoft.AspNetCore.Mvc;

namespace First_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
