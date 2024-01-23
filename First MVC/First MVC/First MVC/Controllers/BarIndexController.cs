using Microsoft.AspNetCore.Mvc;

namespace First_MVC.Controllers
{
    public class ErrorViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
