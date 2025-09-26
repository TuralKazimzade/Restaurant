using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.ViewComponents
{
    public class _NavbarDefaultComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
