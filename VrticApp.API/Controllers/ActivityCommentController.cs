using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.ActivityComment;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityCommentController : ControllerBase
    {
        private readonly IActivityCommentRepository _activityCommentRepository;
        private readonly UserManager<User> _userManager;
        public ActivityCommentController(IActivityCommentRepository activityCommentRepository, UserManager<User> userManager)
        {
            _activityCommentRepository = activityCommentRepository;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _activityCommentRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _activityCommentRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ActivityCommentCreateDTO aComment)
        {
            if (aComment == null)
                return BadRequest();
            var user = await _userManager.GetUserAsync(HttpContext.User);

            return Ok(await _activityCommentRepository.Add(aComment));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ActivityComment aComment)
        {
            if (aComment == null)
                return BadRequest();
            var user = await _userManager.GetUserAsync(HttpContext.User);

            return Ok(await _activityCommentRepository.Update(id,aComment));
        }
    }
}