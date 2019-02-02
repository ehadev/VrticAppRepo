using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.DifficultyLevel;
using VrticApp.API.Interfaces;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DifficultyLevelsController : ControllerBase
    {
        private readonly IDifficultyLevelRepository _difficultyLevelRepository;

        public DifficultyLevelsController(IDifficultyLevelRepository difficultyLevelRepository)
        {
            _difficultyLevelRepository = difficultyLevelRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _difficultyLevelRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _difficultyLevelRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DifficultyLevelCreateDTO difficultyLevel)
        {
            if (difficultyLevel == null)
                return BadRequest();

            return Ok(await _difficultyLevelRepository.Add(difficultyLevel));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, DifficultyLevelUpdateDTO difficultyLevel)
        {
            if (difficultyLevel == null)
                return BadRequest();

            return Ok(await _difficultyLevelRepository.Update(id, difficultyLevel));
        }

    }
}