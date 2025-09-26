using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.ViewComponents.AdminLayoutNavbarViewComponents
{
    public class _NavbarFormInlineComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}