using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.DTOs.MemberShipType;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class MembershipTypeRepository : IMembershipTypeRepository
    {
        private readonly MyContext _context;

        public MembershipTypeRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<List<MembershipTypeGetDTO>> Get()
        {
            return await _context.MembershipTypes.AnyAsync() ? await _context.MembershipTypes.Select(x => new MembershipTypeGetDTO
            {
                MembershipTypeId = x.MembershipTypeId,
                Name = x.Name,
                Description = x.Description,
                IsActive = x.IsActive
            }).ToListAsync() : null;
        }

        public async Task<MembershipTypeGetDTO> Get(int id)
        {
            return await _context.MembershipTypes.AnyAsync() ? await _context.MembershipTypes.Select(x => new MembershipTypeGetDTO
            {
                MembershipTypeId = x.MembershipTypeId,
                Name = x.Name,
                Description = x.Description,
                IsActive = x.IsActive
            }).FirstOrDefaultAsync() : null;
        }

        public async Task<MembershipTypeGetDTO> Add(MembershipTypeCreateDTO membershipType)
        {
            MembershipType mType = new MembershipType
            {
                Name = membershipType.Name,
                Description = membershipType.Description,
                IsActive = membershipType.IsActive
            };

             _context.MembershipTypes.Add(mType);
            await _context.SaveChangesAsync();
            return await Get(mType.MembershipTypeId);
        }

        public async Task<MembershipTypeGetDTO> Update(int id, MembershipTypeUpdateDTO membershipType)
        {
            MembershipType mType = await _context.MembershipTypes.Where(x => x.MembershipTypeId == id).FirstOrDefaultAsync();

            if (mType == null)
                return null;
            mType.Name = membershipType.Name;
            mType.Description = membershipType.Description;
            mType.IsActive = membershipType.IsActive;

            await _context.SaveChangesAsync();
            return await Get(id);
        }
    }
}
