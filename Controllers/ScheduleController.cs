using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using sprinkler_scheduling_service.Models;

namespace sprinkler_scheduling_service.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        [HttpPost]
        [Route("AddSchedule")]
        public void AddSchedule([FromBody] Schedule schedule)
        {
            Console.WriteLine(schedule);
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