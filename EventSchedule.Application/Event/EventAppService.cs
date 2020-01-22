using EventSchedule.Core.Event;

namespace EventSchedule.Application.Event
{
    public class EventAppService : AppServiceBase<Core.Event.Event>, IEventAppService
    {
        private readonly IEventService _eventService;

        public EventAppService(IEventService eventService) : base(eventService)
        {
            _eventService = eventService;
        }
    }
}