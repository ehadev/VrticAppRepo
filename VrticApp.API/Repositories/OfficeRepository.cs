using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.DTOs.Office;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class OfficeRepository : IOfficeRepository
    {
        private readonly MyContext _context;

        public OfficeRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<List<OfficeGetDTO>> Get()
        {
            return await _context.Offices.AnyAsync() ? await _context.Offices.Select(x => new OfficeGetDTO
            {
                OfficeId = x.OfficeId,
                Name = x.Name,
                Address = x.Address,
                City = x.City,
                PostalCode = x.PostalCode,
                Phone = x.Phone,
                IsActive = x.IsActive
            }).ToListAsync() : null;
        }

        public async Task<OfficeGetDTO> Get(int id)
        {
            return await _context.Offices.AnyAsync() ? await _context.Offices.Select(x => new OfficeGetDTO
            {
                OfficeId = x.OfficeId,
                Name = x.Name,
                Address = x.Address,
                City = x.City,
                PostalCode = x.PostalCode,
                Phone = x.Phone,
                IsActive = x.IsActive
            }).FirstOrDefaultAsync() : null;
        }
        public async Task<OfficeGetDTO> Add(OfficeCreateDTO office)
        {
            Office officeObject = new Office
            {
                Name = office.Name,
                Address = office.Address,
                City = office.City,
                PostalCode = office.PostalCode,
                Phone = office.Phone,
                IsActive = office.IsActive
            };
             _context.Offices.Add(officeObject);
            await _context.SaveChangesAsync();
            return await Get(officeObject.OfficeId);

        }
        public async Task<OfficeGetDTO> Update(int id, OfficeUpdateDTO office)
        {
            Office officeObject = await _context.Offices.Where(x => x.OfficeId == id).FirstOrDefaultAsync();
            if (officeObject == null)
                return null;
            officeObject.Name = office.Name;
            officeObject.Address = office.Address;
            officeObject.City = office.City;
            officeObject.PostalCode = office.PostalCode;
            officeObject.Phone = office.Phone;
            officeObject.IsActive = office.IsActive;

            await _context.SaveChangesAsync();
            return await Get(id);
        }
    }
}
