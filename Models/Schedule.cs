using System.Collections.Generic;

namespace sprinkler_scheduling_service.Models
{
    public class Schedule
    {
        public bool Run { get; set; }

        public List<Section> Section { get; set; }
    }
}