using System.Collections.Generic;
using AutoMapper;
using EventSchedule.Application.Event;
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
            return _mapper.Map<IEnumerable<Core.Event.Event>, IEnumerable<EventViewModel>>((IEnumerable<Core.Event.Event>)_eventApp.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<EventViewModel> Get(int id)
        {
            return _mapper.Map<Core.Event.Event, EventViewModel>((Core.Event.Event)_eventApp.GetById(id));
        }

        [HttpPost]
        public void Post([FromBody] EventViewModel eventSchedule)
        {
            _eventApp.Add(_mapper.Map<EventViewModel, Core.Event.Event>(eventSchedule));
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EventViewModel eventSchedule)
        {
           _eventApp.Update(_mapper.Map<EventViewModel, Core.Event.Event>(eventSchedule));
        }

        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] EventViewModel eventSchedule)
        {
            _eventApp.Remove(_mapper.Map<EventViewModel, Core.Event.Event>(eventSchedule));
        }
    }
}