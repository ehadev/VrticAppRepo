using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.CostType;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostTypeController : ControllerBase
    {
        private readonly ICostTypeRepository _cType;

        public CostTypeController(ICostTypeRepository cType)
        {
            _cType = cType;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _cType.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _cType.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CostTypeCreateDTO cType)
        {
            if (cType == null)
                return BadRequest();
            return Ok(await _cType.Add(cType));
        }

        [HttpPost]
        public async Task<IActionResult> Put(int id,CostTypeUpdateDTO cType)
        {
            if (cType == null)
                return BadRequest();
            return Ok(await _cType.Update(id, cType));
        }
    }
}