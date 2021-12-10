using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjetoDaniel.Dto;
using ProjetoDanielApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDanielWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Schedule/")]
    [EnableCors("any")]
    public class ScheduleController : Controller
    {
        private readonly IScheduleAppService _appService;
        public ScheduleController(IScheduleAppService ScheduleAppService)
        {
            _appService = ScheduleAppService;
        }
      

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            return Ok(_appService.GetScheduleById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody]ScheduleDto ScheduleDto)
        {
            return Ok(_appService.SaveSchedule(ScheduleDto));
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody]ScheduleDto ScheduleDto)
        {
            _appService.UpdateSchedule(ScheduleDto);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _appService.DeleteSchedule(id);
            return Ok();
        }
    }
}
