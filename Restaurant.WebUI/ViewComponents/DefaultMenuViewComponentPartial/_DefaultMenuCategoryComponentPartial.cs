using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Restaurant.WebUI.Dtos.CategoryDtos;
using Restaurant.WebUI.Dtos.ServiceDtos;

namespace Restaurant.WebUI.ViewComponents.DefaultMenuViewComponentPartial
{
    public class _DefaultMenuCategoryComponentPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultMenuCategoryComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public  async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7253/api/Categories/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
