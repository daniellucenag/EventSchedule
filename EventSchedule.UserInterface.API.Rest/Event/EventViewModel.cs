using System;
using System.ComponentModel.DataAnnotations;

namespace EventSchedule.UserInterface.API.Rest.Event
{
    public class EventViewModel
    {
        [Key]
        public int EventId { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}