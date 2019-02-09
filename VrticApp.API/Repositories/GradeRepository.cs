using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.DTOs.Grade;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class GradeRepository : Repository<Grade>, IGradeRepository
    {
        public GradeRepository(MyContext context): base(context)
        {
        }
      
        public async Task<Grade> Add(GradeCreateDTO grade)
        {
            Grade gObject = new Grade
            {
                Name = grade.Name,
                Description = grade.Description,
                IsActive = grade.IsActive
            };
             _context.Grades.Add(gObject);
            await _context.SaveChangesAsync();
            return await Get(grade.GradeId);
            
        }

        public async Task<Grade> Update(int id, GradeUpdateDTO grade)
        {
            Grade gObject = await _context.Grades.Where(x => x.GradeId == id).FirstOrDefaultAsync();
            if (gObject == null)
                return null;
            gObject.Name = grade.Name;
            gObject.Description = grade.Description;
            gObject.IsActive = grade.IsActive;

            await _context.SaveChangesAsync();
            return await Get(id);
        }
    }
}
