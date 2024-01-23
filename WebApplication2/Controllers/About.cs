using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult second()
        {
            return View();
        }
    }
}
