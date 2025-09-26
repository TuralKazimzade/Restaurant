using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Restaurant.WebUI.Dtos.CategoryDtos;
using Restaurant.WebUI.Dtos.ProductDtos;

namespace Restaurant.WebUI.ViewComponents.DefaultMenuViewComponentPartial
{
    public class _DefaultMenuProductComponentPartial:ViewComponent
    {
       private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultMenuProductComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7253/api/Products/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
