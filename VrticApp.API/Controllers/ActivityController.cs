using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.Activity;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityRepository _activityRepository;
        private readonly UserManager<User> _userManager;

        public ActivityController(IActivityRepository activityRepository, UserManager<User> userManager)
        {
            _activityRepository = activityRepository;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _activityRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _activityRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(ActivityCreateDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            // user

            var user = await _userManager.GetUserAsync(HttpContext.User);

            // mapping
            var activity = new Activity()
            {
                ActivityTypeId = model.ActivityTypeId,
                DifficultyLevelId = model.DifficultyLevelId,
                UserId = user.Id,
                Name = model.Name,
                Description = model.Description,
                Duration = model.Duration,
                Date = model.Date,
                IsActive = model.IsActive

            };
           
            return Ok(await _activityRepository.Add(activity));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Activity model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var activityEntity = await _activityRepository.Get(id);

            if (activityEntity == null)
                return NotFound();

            var user = await _userManager.GetUserAsync(HttpContext.User);

            activityEntity.ActivityTypeId = model.ActivityTypeId;
            activityEntity.DifficultyLevelId = model.DifficultyLevelId;
            activityEntity.UserId = user.Id;
            activityEntity.Name = model.Name;
            activityEntity.Description = model.Description;
            activityEntity.Date = model.Date;
            activityEntity.Duration = model.Duration;
            activityEntity.IsActive = model.IsActive;

            return Ok(await _activityRepository.Update(id, model));
        }



    }
}