using System;

namespace EventSchedule.Core.Event
{
    public class Event
    {
        public int EventId { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}