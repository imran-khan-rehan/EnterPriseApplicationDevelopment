using Microsoft.AspNetCore.Mvc;

namespace First_MVC.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
