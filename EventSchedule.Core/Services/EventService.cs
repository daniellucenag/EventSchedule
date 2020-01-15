using EventSchedule.Core.Entities;
using EventSchedule.Core.Interfaces.Repositories;
using EventSchedule.Core.Interfaces.Services;
using EventSchedule.Core.Interfaces.UnitOfWork;

namespace EventSchedule.Core.Services
{
    public class EventService : ServiceBase<Event>, IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IUnitOfWork _unitOfWork;
        public EventService(IEventRepository eventRepository, IUnitOfWork unitOfWork)
            : base(eventRepository, unitOfWork)
        {
            _eventRepository = eventRepository;
            _unitOfWork = unitOfWork;
        }
    }
}