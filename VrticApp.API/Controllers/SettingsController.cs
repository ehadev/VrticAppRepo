using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.Settings;
using VrticApp.API.Interfaces;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingsRepository _settingsRepository;

        public SettingsController(ISettingsRepository settingsRepository)
        {
            _settingsRepository = settingsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _settingsRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _settingsRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SettingsCreateDTO settings)
        {
            if (settings == null)
                return BadRequest();

            return Ok(await _settingsRepository.Add(settings));
        }

        [HttpPost]
        public async Task<IActionResult> Put(int id, SettingsUpdateDTO settings)
        {
            if (settings == null)
                return BadRequest();

            return Ok(await _settingsRepository.Update(id,settings));
        }


    }
}