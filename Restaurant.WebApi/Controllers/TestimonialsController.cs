using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.WebApi.Context;
using Restaurant.WebApi.Entities;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ApiContext _context;

        public TestimonialsController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _context.Testimonials.ToList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial Testimonial)
        {
            _context.Testimonials.Add(Testimonial);
            _context.SaveChanges();
            return Ok("Əlavəetmə əməliyyatı uğurla tamamlandı");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(value);
            _context.SaveChanges();
            return Ok("Silinmə əməliyyatı uğurla tamamlandı");
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial Testimonial)
        {
            _context.Testimonials.Update(Testimonial);
            _context.SaveChanges();
            return Ok("Güncəlləmə əməliyyatı uğurla tamamlandı");
        }
    }
}
