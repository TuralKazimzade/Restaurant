using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.WebApi.Context;
using Restaurant.WebApi.Entities;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly ApiContext _context;

        public EventsController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult EventList()
        {
            var value = _context.Events.ToList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateEvent(Event Event)
        {
            _context.Events.Add(Event);
            _context.SaveChanges();
            return Ok("Əlavəetmə əməliyyatı uğurla tamamlandı");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEvent(int id)
        {
            var value = _context.Events.Find(id);
            _context.Events.Remove(value);
            _context.SaveChanges();
            return Ok("Silinmə əməliyyatı uğurla tamamlandı");
        }
        [HttpGet("{id}")]
        public IActionResult GetEvent(int id)
        {
            var value = _context.Events.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateEvent(Event Event)
        {
            _context.Events.Update(Event);
            _context.SaveChanges();
            return Ok("Güncəlləmə əməliyyatı uğurla tamamlandı");
        }
    }
}
