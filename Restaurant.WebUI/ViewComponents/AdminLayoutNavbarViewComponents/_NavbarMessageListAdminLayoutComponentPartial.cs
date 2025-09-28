using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Restaurant.WebUI.Dtos.MessageDtos;
using System.Text.Json;

namespace Restaurant.WebUI.ViewComponents.AdminLayoutNavbarViewComponents
{
    public class _NavbarMessageListAdminLayoutComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _NavbarMessageListAdminLayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7253/api/Messages/MessageListByIsReadFlse");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ResultMessageByIsReadFalseDto>>(jsonData);

                return View(result);
            }
            return View();
        } 
    }
}
