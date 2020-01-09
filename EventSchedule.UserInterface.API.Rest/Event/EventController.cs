using System.Collections.Generic;
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
            var _event = _mapper.Map<IEnumerable<Core.Entities.Event>, 
                IEnumerable<EventViewModel>>(_eventApp.GetAll());
            return _event;
        }

        [HttpGet("{id}")]
        public ActionResult<EventViewModel> Get(int id)
        {
            var _event = _mapper.Map<Core.Entities.Event, EventViewModel>(_eventApp.GetById(id));
            return _event;
        }

        [HttpPost]
        public void Post([FromBody] EventViewModel eventSchedule)
        {
            var _event = _mapper.Map<EventViewModel, Core.Entities.Event>(eventSchedule);
            _eventApp.Add(_event);
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] EventViewModel eventSchedule)
        {
            var _event = _mapper.Map<EventViewModel, Core.Entities.Event>(eventSchedule);
            _eventApp.Update(_event);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] EventViewModel eventSchedule)
        {
            var _event = _mapper.Map<EventViewModel, Core.Entities.Event>(eventSchedule);
            _eventApp.Remove(_event);
        }
    }
}