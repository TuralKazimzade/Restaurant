using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.ViewComponents
{
    public class _FeatureDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
