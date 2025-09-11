using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.WebApi.Context;
using Restaurant.WebApi.Dtos.ContactDtos;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ContactsController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _context.Contacts.ToList();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {             var contact = new Entities.Contact
            {
                MapLocation = createContactDto.MapLocation,
                Phone = createContactDto.Phone,
                Email = createContactDto.Email,
                Address = createContactDto.Address,
                OpenHours = createContactDto.OpenHours
            };
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok(contact);
        }
    }
}
