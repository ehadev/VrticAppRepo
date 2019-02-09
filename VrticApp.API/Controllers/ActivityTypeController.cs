using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.ActivityType;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityTypeController : ControllerBase
    {
        private readonly IActivityTypeRepository _activityType;
        public ActivityTypeController(IActivityTypeRepository activityType)
        {
            //test
            _activityType = activityType;
        }

        [HttpGet]
        public async Task<IActionResult>Get()
        {
            return Ok(await _activityType.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>Get(int id)
        {
            return Ok(_activityType.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ActivityType aType)
        {
            if (aType == null)
                return BadRequest();
            return Ok(await _activityType.Add(aType));
        }
        [HttpPost]
        public async Task<IActionResult> Put(int id,ActivityTypeUpdateDTO aType)
        {

            if (aType == null)
                return BadRequest();

            return Ok(await _activityType.Update(id, aType));
        }
    }
}