using AutoMapper;

namespace EventSchedule.UserInterface.API.Rest.Event
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Core.Entities.Event, EventViewModel>().ReverseMap();
        }
    }
}
