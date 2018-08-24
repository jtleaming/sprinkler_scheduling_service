using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace sprinkler_scheduling_service.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        [HttpPost]
        [Route("AddSchedule")]
        public void AddSchedule([FromBody] object schedule)
        {
            Debug.WriteLine(schedule);
        }

        [HttpGet("{id}")]
        public string GetSchedule(int id)
        {
            return $"Something {id.ToString()}";
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Something fucking happen for fucks sake";
        }
    }
}