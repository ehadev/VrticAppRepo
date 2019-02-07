using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.Office;
using VrticApp.API.Interfaces;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly IOfficeRepository _officeRepository;

        public OfficeController(IOfficeRepository officeRepository)
        {
            _officeRepository = officeRepository;
        }

        [HttpGet]
        public async Task<IActionResult>Get()
        {
            return Ok(await _officeRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _officeRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]OfficeCreateDTO office)
        {
            if (office == null)
                return BadRequest();
            return Ok(await _officeRepository.Add(office));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,OfficeUpdateDTO office)
        {
            if (office == null)
                return BadRequest();
            return Ok(await _officeRepository.Update(id,office));
        }

    }
}