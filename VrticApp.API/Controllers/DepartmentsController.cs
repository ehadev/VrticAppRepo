using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VrticApp.API.DTOs.Department;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
            //test
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _departmentRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _departmentRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Department department)
        {
            if (department == null)
                return BadRequest();

            return Ok(await _departmentRepository.Add(department));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, DepartmentUpdateDTO department)
        {
            if (department == null)
                return BadRequest();

            return Ok(await _departmentRepository.Update(id,department));
        }
    }
}