using Microsoft.AspNetCore.Mvc;

namespace BikeShop.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
