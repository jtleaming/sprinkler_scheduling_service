using System.Collections.Generic;
using Newtonsoft.Json;

namespace sprinkler_scheduling_service.Models
{
    public class Schedule
    {
        public bool Run { get; set; }

        public List<Section> Sections { get; set; }

        public int Id { get; set; }

        public Schedule()
        {
        }
    }
}