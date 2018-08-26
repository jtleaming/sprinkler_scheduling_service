using System;
using System.Collections.Generic;

namespace sprinkler_scheduling_service.Models
{
    public class Section
    {

        public string StartTime { get; set; }
        public int Duration { get; set; }
        public List<string> Days { get; set; }
        public int ZoneNumber { get; set; }
        public int Id { get; set; }
        public int ScheduleId { get; set; }
    }
}