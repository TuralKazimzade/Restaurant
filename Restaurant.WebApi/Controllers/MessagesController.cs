using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.WebApi.Context;
using Restaurant.WebApi.Dtos.MessageDtos;
using Restaurant.WebApi.Entities;

namespace Restaurant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;

        public MessagesController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var value = _context.Messages.ToList();
            return Ok(_mapper.Map<List<ResultMessageDto>>(value));
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            var message = _mapper.Map<Message>(createMessageDto);
            _context.Messages.Add(message);
            _context.SaveChanges();
            return Ok("Əlavəetmə əməliyyatı uğurla tamamlandı");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return Ok("Silinmə əməliyyatı uğurla tamamlandı");
        }
        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var value = _context.Messages.Find(id);
            return Ok(_mapper.Map<GetByIdMessageDto>(value));
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            var message = _mapper.Map<Message>(updateMessageDto);
            _context.Messages.Update(message);
            _context.SaveChanges();
            return Ok("Güncəlləmə əməliyyatı uğurla tamamlandı");
        }
        [HttpGet("MessageListByIsReadFlse")]
        public IActionResult MessageListByIsReadFlse()
        {
            var value = _context.Messages.Where(x => x.IsRead == false).ToList();
            return Ok(value);
        }
    }
}
