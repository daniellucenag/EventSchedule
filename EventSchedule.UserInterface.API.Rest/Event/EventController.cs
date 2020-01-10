using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EventSchedule.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventSchedule.UserInterface.API.Rest.Event
{
    [Route("UserInterface/API/Rest/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventAppService _eventApp;
        private readonly IMapper _mapper;

        public EventController(IMapper mapper, IEventAppService eventApp)
        {
            _mapper = mapper;
            _eventApp = eventApp;
        }

        [HttpGet]
        public IEnumerable<EventViewModel> Get()
        {
            return _mapper.Map<IEnumerable<Core.Entities.Event>, IEnumerable<EventViewModel>>(_eventApp.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<EventViewModel> Get(int id)
        {
            return _mapper.Map<Core.Entities.Event, EventViewModel>(_eventApp.GetById(id));
        }

        [HttpPost]
        public async Task Post([FromBody] EventViewModel eventSchedule)
        {
            await _eventApp.Add(_mapper.Map<EventViewModel, Core.Entities.Event>(eventSchedule));
        }

        [HttpPut("{id}")]
        public async Task Put(int id,[FromBody] EventViewModel eventSchedule)
        {
           await _eventApp.Update(_mapper.Map<EventViewModel, Core.Entities.Event>(eventSchedule));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task Delete(int id, [FromBody] EventViewModel eventSchedule)
        {
            await _eventApp.Remove(_mapper.Map<EventViewModel, Core.Entities.Event>(eventSchedule));
        }
    }
}