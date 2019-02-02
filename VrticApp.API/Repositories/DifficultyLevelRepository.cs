using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.DTOs.DifficultyLevel;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class DifficultyLevelRepository : IDifficultyLevelRepository
    {
        private readonly MyContext _context;

        public DifficultyLevelRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<List<DifficultyLevelGetDTO>> Get()
        {
            return   await _context.DifficultyLevels.AnyAsync() ?
                     await _context.DifficultyLevels.Select(x => new DifficultyLevelGetDTO
                     {
                         DifficultyLevelId = x.DifficultyLevelId,
                         Name = x.Name,
                         Description = x.Description,
                         IsActive = x.IsActive
                     }).ToListAsync() : null;
        }

        public async Task<DifficultyLevelGetDTO> Get(int id)
        {
            return  await _context.DifficultyLevels.AnyAsync() ?
                    await _context.DifficultyLevels.Select(x => new DifficultyLevelGetDTO
                    {
                        DifficultyLevelId = x.DifficultyLevelId,
                        Name = x.Name,
                        Description = x.Description,
                        IsActive = x.IsActive
                    }).FirstOrDefaultAsync() : null;
        }


        public async Task<DifficultyLevelGetDTO> Add(DifficultyLevelCreateDTO difficultyLevel)
        {
            DifficultyLevel difficultyLevelObject = new DifficultyLevel
            {
                Name = difficultyLevel.Name,
                Description = difficultyLevel.Description,
                IsActive = difficultyLevel.IsActive
            };

            await _context.DifficultyLevels.AddAsync(difficultyLevelObject);
            await _context.SaveChangesAsync();

            return await Get(difficultyLevelObject.DifficultyLevelId);
        }


        public async Task<DifficultyLevelGetDTO> Update(int id, DifficultyLevelUpdateDTO difficultyLevel)
        {
            DifficultyLevel difficultyLevelObject = await _context.DifficultyLevels.Where(x => x.DifficultyLevelId == id)
                                                                                   .FirstOrDefaultAsync();

            if (difficultyLevelObject == null)
                return null;

            difficultyLevelObject.Name = difficultyLevel.Name;
            difficultyLevelObject.Description = difficultyLevel.Description;
            difficultyLevelObject.IsActive = difficultyLevel.IsActive;

            await _context.SaveChangesAsync();

            return await Get(id);
        }

    }
}
