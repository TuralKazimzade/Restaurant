using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.WebApi.Context;
using Restaurant.WebApi.Entities;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ChefsController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ChefList()
        {
            var value = _context.Chefs.ToList();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateChef(Chef chef)
        {
            _context.Chefs.Add(chef);
            _context.SaveChanges();
            return Ok("Aşpaz Uğurla Əlavə olundu");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteChef(int id)
        {
            var value = _context.Chefs.Find(id);
            _context.Chefs.Remove(value);
            _context.SaveChanges();
            return Ok("Aşpaz Uğurla Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetChef(int id)
        {
            var value = _context.Chefs.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateChef(Chef chef)
        {
            _context.Chefs.Update(chef);
            _context.SaveChanges();
            return Ok("Aşpaz Uğurla Güncəlləndi");
        }
    }
}
