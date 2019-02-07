using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.CostType;
using VrticApp.API.Interfaces;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostTypeController : ControllerBase
    {
        private readonly ICostTypeRepository _cTypeRepository;

        public CostTypeController(ICostTypeRepository cTypeRepository)
        {
            _cTypeRepository = cTypeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _cTypeRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _cTypeRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CostTypeCreateDTO cType)
        {
            if (cType == null)
                return BadRequest();

            return Ok(await _cTypeRepository.Add(cType));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,CostTypeUpdateDTO cType)
        {
            if (cType == null)
                return BadRequest();

            return Ok(await _cTypeRepository.Update(id,cType));
        }
    }
}