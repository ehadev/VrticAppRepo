using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.MemberShipType;
using VrticApp.API.Interfaces;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipTypeController : ControllerBase
    {
        private readonly IMembershipTypeRepository _mTypeRepositoray;

        public MembershipTypeController(IMembershipTypeRepository mTypeRepository)
        {
            _mTypeRepositoray = mTypeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mTypeRepositoray.Get());
        }

        [HttpGet ("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _mTypeRepositoray.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MembershipTypeCreateDTO mType)
        {
            if (mType == null)
                return BadRequest();
            return Ok(await _mTypeRepositoray.Add(mType));
        }

        [HttpPut ("{id}")]
        public async Task<IActionResult> Put(int id,MembershipTypeUpdateDTO mType)
        {
            if (mType == null)
                return BadRequest();
            return Ok(await _mTypeRepositoray.Update(id,mType));
        }

    }
}