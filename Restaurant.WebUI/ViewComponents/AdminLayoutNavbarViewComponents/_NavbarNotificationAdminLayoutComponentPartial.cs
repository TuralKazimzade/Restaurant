using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Restaurant.WebUI.Dtos.MessageDtos;
using Restaurant.WebUI.Dtos.NotificationDtos;

namespace Restaurant.WebUI.ViewComponents.AdminLayoutNavbarViewComponents
{
    public class _NavbarNotificationAdminLayoutComponentPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _NavbarNotificationAdminLayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7253/api/Notifications");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ResultNotificationDto>>(jsonData);

                return View(result);
            }
            return View();
        }
    }
}
