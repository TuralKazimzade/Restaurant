using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.ViewComponents.DefaultMenuViewComponentPartial
{
    public class _DefaultMenuViewComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
