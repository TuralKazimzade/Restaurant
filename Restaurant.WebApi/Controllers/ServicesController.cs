using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.WebApi.Context;
using Restaurant.WebApi.Entities;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ApiContext _context;

        public ServicesController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var value = _context.Services.ToList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
            return Ok("Əlavəetmə əməliyyatı uğurla tamamlandı");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return Ok("Silinmə əməliyyatı uğurla tamamlandı");
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var value = _context.Services.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _context.Services.Update(service);
            _context.SaveChanges();
            return Ok("Güncəlləmə əməliyyatı uğurla tamamlandı");
        }
    }
}
