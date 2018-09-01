using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using sprinkler_scheduling_service.Models;

namespace sprinkler_scheduling_service.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly WebApiContext context;

        public ScheduleController(WebApiContext context)
        {
            this.context = context;
        }
        [HttpPost]
        [Route("AddSchedule")]
        public ActionResult AddSchedule([FromBody] Schedule schedule)
        {
            try
            {
                if(context.Find(typeof(Schedule), schedule.Id) != null)
                {
                    throw new Exception($"Schedule {schedule.Id} already exists");
                }

                context.Schedules.Add(schedule);
                context.SaveChanges();
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
            
        }

        [HttpPut]
        [Route("EditSchedule")]
        public ActionResult EditSchedule([FromBody] Schedule schedule)
        {
            try
            {
                context.Schedules.Update(schedule);
                context.SaveChanges();
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }

        }


        [HttpGet("{id}")]
        public string GetSchedule(int id)
        {
            var schedule = context.Schedules.Where(s => s.Id == id).Include(s => s.Sections).First();
            var jsonSchedule = JsonConvert.SerializeObject(schedule);
            return jsonSchedule;
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Something fucking happen for fucks sake";
        }
    }
}