using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.Grade;
using VrticApp.API.Interfaces;
using VrticApp.API.UOW;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GradeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult>Get()
        {
            return Ok( await _unitOfWork.GradeRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _unitOfWork.GradeRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post ([FromBody] GradeCreateDTO grade)
        {
            if (grade == null)
                return BadRequest();

            return Ok(await _unitOfWork.GradeRepository.Add(grade));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,GradeUpdateDTO grade)
        {
            if (grade == null)
                return BadRequest();
            return Ok(await _unitOfWork.GradeRepository.Update(id, grade));
        }
    }
}