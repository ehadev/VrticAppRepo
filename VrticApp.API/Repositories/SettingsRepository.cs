using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.DTOs.Settings;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class SettingsRepository : ISettingsRepository
    {
        private readonly MyContext _context;

        public SettingsRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<List<SettingsGetDTO>> Get()
        {
            return await _context.Settings.AnyAsync() ? await _context.Settings.Select(x => new SettingsGetDTO
            {
                SettingsId = x.SettingsId,
                Value = x.Value,
                Description = x.Description,
                IsActive = x.IsActive
            }).ToListAsync() : null;
        }

        public async  Task<SettingsGetDTO> Get(int id)
        {
            return await _context.Settings.AnyAsync() ? await _context.Settings.Select(x => new SettingsGetDTO
            {
                SettingsId = x.SettingsId,
                Value = x.Value,
                Description = x.Description,
                IsActive = x.IsActive
            }).FirstOrDefaultAsync() : null;
        }

        public async Task<SettingsGetDTO> Add(SettingsCreateDTO settings)
        {
            Settings sObject = new Settings
            {
                Value = settings.Value,
                Description = settings.Description,
                IsActive = settings.IsActive
            };
            await _context.Settings.AddAsync(sObject);
            await _context.SaveChangesAsync();
            return await Get(sObject.SettingsId);
      
        }

        public async Task<SettingsGetDTO> Update(int id, SettingsUpdateDTO settings)
        {
            Settings sObject = await _context.Settings.Where(x => x.SettingsId == id).FirstOrDefaultAsync();
            if (sObject == null)
                return null;
            sObject.Value = settings.Value;
            sObject.Description = settings.Description;
            sObject.IsActive = settings.IsActive;

            await _context.SaveChangesAsync();
            return await Get(id);
        }
    }
}
