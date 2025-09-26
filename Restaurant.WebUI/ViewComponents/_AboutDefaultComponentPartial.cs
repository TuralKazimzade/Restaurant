using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.ViewComponents
{
    public class _AboutDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
