using EventSchedule.Core.Event;
using EventSchedule.Infraestructure.Data.Context;

namespace EventSchedule.Infraestructure.Data.Event
{
    public class EventRepository : RepositoryBase<Core.Event.Event>, IEventRepository
    {
        public EventRepository(EventScheduleContext context) : base(context)
        {
        }
    }
}