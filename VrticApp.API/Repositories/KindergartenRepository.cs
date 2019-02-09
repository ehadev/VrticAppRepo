using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.DTOs.Kindergarten;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class KindergartenRepository : IKindergartenRepository
    {
        private readonly MyContext _context;

        public KindergartenRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<List<KindergartenGetDTO>> Get()
        {
            return await _context.Kindergartens.AnyAsync() ? await _context.Kindergartens.Select(x => new KindergartenGetDTO
            {
                KindergartenId = x.KindergartenId,
                Name = x.Name,
                Address = x.Address,
                Phone = x.Phone,
                Email = x.Email,
                Web = x.Web,
                Owner = x.Owner,
                LogoURL = x.LogoURL,
                IsDeleted = x.IsDeleted
            }).ToListAsync() : null;
        }

        public async  Task<KindergartenGetDTO> Get(int id)
        {
            return await _context.Kindergartens.AnyAsync() ? await _context.Kindergartens.Select(x => new KindergartenGetDTO
            {
                KindergartenId = x.KindergartenId,
                Name = x.Name,
                Address = x.Address,
                Phone = x.Phone,
                Email = x.Email,
                Web = x.Web,
                Owner = x.Owner,
                LogoURL = x.LogoURL,
                IsDeleted = x.IsDeleted
            }).FirstOrDefaultAsync() : null;
        }
        public async Task<KindergartenGetDTO> Add(KindergartenCreateDTO kindergarten)
        {
            Kindergarten kObject = new Kindergarten
            {
                Name = kindergarten.Name,
                Address = kindergarten.Address,
                Phone = kindergarten.Phone,
                Email = kindergarten.Email,
                Web = kindergarten.Web,
                Owner = kindergarten.Owner,
                LogoURL = kindergarten.LogoURL,
                IsDeleted = kindergarten.IsDeleted
            };

            await _context.Kindergartens.AddAsync(kObject);
            await _context.SaveChangesAsync();
            return await Get(kObject.KindergartenId);

        }
        public async Task<KindergartenGetDTO> Update(int id, KindergartenUpdateDTO kindergarten)
        {
            Kindergarten kObject = await _context.Kindergartens.Where(x => x.KindergartenId == id).FirstOrDefaultAsync();

            if (kObject == null)
                return null;
            kObject.Name = kindergarten.Name;
            kObject.Address = kindergarten.Address;
            kObject.Phone = kindergarten.Phone;
            kObject.Email = kindergarten.Email;
            kObject.Web = kindergarten.Web;
            kObject.Owner = kindergarten.Owner;
            kObject.LogoURL = kindergarten.LogoURL;
            kObject.IsDeleted = kindergarten.IsDeleted;

            await _context.SaveChangesAsync();
            return await Get(id);
        }
    }
}
