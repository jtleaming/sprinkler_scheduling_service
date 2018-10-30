using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using sprinkler_scheduling_service.Models;

namespace sprinkler_scheduling_service.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly WebApiContext context;

        public SectionController(WebApiContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<string> Get(int sectionId, int scheduleId)
        {
            var section = context.Sections.FirstOrDefault(s => 
                            s.ScheduleId == scheduleId && 
                            s.Id == sectionId
                            );
            return JsonConvert.SerializeObject(section);
        }

        [HttpGet]
        [Route("Sections")]
        public ActionResult<string> Sections(int scheduleId)
        {
            try
            {
                var sections = context.Sections.Where(s => s.ScheduleId == scheduleId);
                return JsonConvert.SerializeObject(sections);
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
                throw;
            }
        }
    }
}