using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _NavbarAdminLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
