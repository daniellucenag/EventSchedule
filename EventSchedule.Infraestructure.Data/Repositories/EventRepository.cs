using EventSchedule.Core.Entities;
using EventSchedule.Core.Interfaces.Repositories;
using EventSchedule.Infraestructure.Data.Context;

namespace EventSchedule.Infraestructure.Data.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(EventScheduleContext context) : base(context)
        {
        }
    }
}