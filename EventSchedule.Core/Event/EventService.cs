namespace EventSchedule.Core.Event
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