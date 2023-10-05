using Microsoft.AspNetCore.Mvc;
using Jazani.Application.Generals.Dtos.Notifications;
using Jazani.Application.Generals.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jazani.Api.Controllers.Generals
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        
         
        // GET: api/<NotificationTypeController>
        [HttpGet]
        public async Task<IEnumerable<NotificationDto>> Get()
        {
            return await _notificationService.FindAllAsync();

        }

        // GET api/<NotificationTypeController>/5
        [HttpGet("{id}")]
        public async Task<NotificationDto> Get(int id)
        {
            return await _notificationService.FindByIdAsync(id);
        }

        // POST api/<NotificationTypeController>
        [HttpPost]
        public async Task<NotificationDto> Post([FromBody] NotificationSaveDto saveDto)
        {
            return await _notificationService.CreateAsync(saveDto);
        }

        // PUT api/<NotificationTypeController>/5
        [HttpPut("{id}")]
        public async Task<NotificationDto> Put(int id, [FromBody] NotificationSaveDto saveDto)
        {
            return await _notificationService.EditAsync(id, saveDto);
        }

        // DELETE api/<NotificationTypeController>/5
        [HttpDelete("{id}")]
        public async Task<NotificationDto> Delete(int id)
        {
            return await _notificationService.DisabledAsync(id);
        }
         

    }
}
