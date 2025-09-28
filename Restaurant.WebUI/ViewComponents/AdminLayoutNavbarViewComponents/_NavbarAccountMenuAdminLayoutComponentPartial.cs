using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.ViewComponents.AdminLayoutNavbarViewComponents
{
    public class _NavbarAccountMenuAdminLayoutComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _NavbarAccountMenuAdminLayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
