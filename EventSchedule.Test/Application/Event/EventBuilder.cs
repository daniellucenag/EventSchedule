using System;
using System.Collections.Generic;

namespace EventSchedule.Test.Application.Event
{
    public class EventBuilder
    {
        public IEnumerable<Core.Event.Event> AllEvents { get; set; }
        public Core.Event.Event SingleEvent { get; set; }
        public IEnumerable<Core.Event.Event> EmptyList {get;set;}
        public Core.Event.Event EmptyEvent { get; set; }

        public EventBuilder GetValidInstance()
        {
            return new EventBuilder()
            {
                AllEvents = new List<Core.Event.Event>()
                {
                    new Core.Event.Event()
                    {
                        EventId = 1,
                        EventStart = DateTime.Now,
                        EventEnd = DateTime.Now.AddDays(1),
                        Description = "First of the list",
                    },
                    new Core.Event.Event()
                    {
                        EventId = 2,
                        EventStart = DateTime.Now.AddDays(2),
                        EventEnd = DateTime.Now.AddDays(3),
                        Description = "Second of the list",
                    }
                },
                SingleEvent = new Core.Event.Event()
                {
                    EventId = 3,
                    EventStart = DateTime.Now,
                    EventEnd = DateTime.Now.AddDays(2),
                    Description = "First of single"
                },
                EmptyList = null,
                EmptyEvent = null
            };
        }

    }
}
