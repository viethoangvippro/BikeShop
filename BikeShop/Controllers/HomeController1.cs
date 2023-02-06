using Microsoft.AspNetCore.Mvc;

namespace BikeShop.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
