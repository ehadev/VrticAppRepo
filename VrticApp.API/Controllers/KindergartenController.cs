using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.Kindergarten;
using VrticApp.API.Interfaces;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KindergartenController : ControllerBase
    {
        private readonly IKindergartenRepository _kindergartenRepository;

        public KindergartenController(IKindergartenRepository kindergartenRepository)
        {
            _kindergartenRepository = kindergartenRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _kindergartenRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _kindergartenRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] KindergartenCreateDTO kindergarten)
        {
            if (kindergarten == null)
                return BadRequest();

            return Ok(await _kindergartenRepository.Add(kindergarten));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,KindergartenUpdateDTO kindergarten)
        {
            if (kindergarten == null)
                return BadRequest();

            return Ok(await _kindergartenRepository.Update(id,kindergarten));
        }
    }
}