using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace sprinkler_scheduling_service.Models
{
    public class Section
    {

        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public List<string> Days { get; set; }
        public int ZoneNumber { get; set; }
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        [JsonIgnore]
        public Schedule Schedule { get; set;}
    }
}