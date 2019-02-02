using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.DTOs.Department;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly MyContext _context;

        public DepartmentRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> Get()
        {
            return  await _context.Departments.AnyAsync() ?
                    await _context.Departments.ToListAsync() : null;
        }

        public async Task<Department> Get(int id)
        {
            return await _context.Departments.AnyAsync() ?
                   await _context.Departments.Where(x=>x.DepartmentId == id).FirstOrDefaultAsync() : null;
        }

        public async Task<Department> Add(Department department)
        {
           await _context.Departments.AddAsync(department);
           await _context.SaveChangesAsync();

           return await Get(department.DepartmentId);
        }

        public async Task<Department> Update(int id, DepartmentUpdateDTO department)
        {
            var departmentDB = await _context.Departments.Where(x => x.DepartmentId == id).FirstOrDefaultAsync();

            if (departmentDB == null)
                return null;

            departmentDB.Name = department.Name;
            departmentDB.Description = department.Description;
            department.IsActive = department.IsActive;

            await _context.SaveChangesAsync();

            return await Get(id);
        }
       
    }
}
