using EventSchedule.Application.Interfaces;
using EventSchedule.Core.Entities;
using EventSchedule.Core.Interfaces.Services;

namespace EventSchedule.Application
{
    public class EventAppService : AppServiceBase<Event>, IEventAppService
    {
        private readonly IEventService _eventService;

        public EventAppService(IEventService eventService) : base(eventService)
        {
            _eventService = eventService;
        }
    }
}