using EventSchedule.Core.Entities;
using EventSchedule.Core.Interfaces.Repositories;

namespace EventSchedule.Infraestructure.Data.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
    }
}