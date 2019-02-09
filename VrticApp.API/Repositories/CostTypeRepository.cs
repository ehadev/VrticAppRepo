using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.DTOs.CostType;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class CostTypeRepository : ICostTypeRepository
    {
        private readonly MyContext _context;
        public CostTypeRepository(MyContext context)
        {
            _context = context;
        }
       
        public async Task<List<CostTypeGetDTO>> Get()
        {
            return await _context.CostTypes.AnyAsync() ? await _context.CostTypes.Select(x => new CostTypeGetDTO
            {
                CostTypeId = x.CostTypeId,
                Name = x.Name,
                Description = x.Description,
                IsActive = x.IsActive
            }).ToListAsync() : null;
           
        }

        public async Task<CostTypeGetDTO> Get(int id)
        {
            return await _context.CostTypes.AnyAsync() ? await _context.CostTypes.Select(x => new CostTypeGetDTO
            {
                CostTypeId = x.CostTypeId,
                Name = x.Name,
                Description = x.Description,
                IsActive = x.IsActive
            }).FirstOrDefaultAsync() : null;
        }
        public async Task<CostTypeGetDTO> Add(CostTypeCreateDTO costType)
        {
            CostType cType = new CostType
            {
                Name = costType.Name,
                Description = costType.Description,
                IsActive = costType.IsActive
            };
             await _context.CostTypes.AddAsync(cType);
            await _context.SaveChangesAsync();
            return await Get(cType.CostTypeId);

        }

        public async Task<CostTypeGetDTO> Update(int id, CostTypeUpdateDTO costType)
        {
            CostType cType = await _context.CostTypes.Where(x => x.CostTypeId == id).FirstOrDefaultAsync();
            if (cType == null)
                return null;
            cType.Name = costType.Name;
            cType.Description = costType.Description;
            cType.IsActive = costType.IsActive;

            await _context.SaveChangesAsync();
            return await Get(id);
        }

      
    }
}
