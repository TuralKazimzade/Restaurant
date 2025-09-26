using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.ViewComponents
{
    public class _FooterDefaultComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
