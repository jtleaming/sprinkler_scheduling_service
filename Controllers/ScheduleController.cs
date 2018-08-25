using System;
using System.Diagnostics;
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
        [HttpPost]
        [Route("AddSchedule")]
        public ActionResult AddSchedule([FromBody] Schedule schedule)
        {
            try
            {
                using (var db = new WebApiContext(new DbContextOptions<WebApiContext>()))
                {
                    db.Schedules.Add(schedule);
                    db.SaveChanges();
                };
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
            return $"Something {id.ToString()}";
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Something fucking happen for fucks sake";
        }
    }
}