using EventSchedule.Core.Entities;
using EventSchedule.Core.Interfaces.Repositories;
using EventSchedule.Core.Interfaces.Services;

namespace EventSchedule.Core.Services
{
    public class EventService : ServiceBase<Event>, IEventService
    {
        private readonly IEventRepository _eventRepository;
        public EventService(IEventRepository eventRepository)
            : base(eventRepository)
        {
            _eventRepository = eventRepository;
        }
    }
}