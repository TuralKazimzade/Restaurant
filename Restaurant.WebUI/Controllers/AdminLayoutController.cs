using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
