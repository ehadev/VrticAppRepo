using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.DTOs.ActivityType;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ActivityTypeRepository : IActivityTypeRepository
    {

        private readonly MyContext _context;

        public ActivityTypeRepository(MyContext context)
        {
            _context = context;
        }
        public async Task<List<ActivityType>> Get()
        {
            return await _context.ActivityTypes.AnyAsync() ? 
                   await _context.ActivityTypes.ToListAsync() : null;
                    
        }

        public async Task<ActivityType> Get(int id)
        {
            return await _context.ActivityTypes.AnyAsync() ?
                    await _context.ActivityTypes.Where(x => x.ActivityTypeId == id).FirstOrDefaultAsync() : null;
        }
        public async Task<ActivityType> Add(ActivityType activityType)
        {
            await _context.ActivityTypes.AddAsync(activityType);
            await _context.SaveChangesAsync();

            return await Get(activityType.ActivityTypeId);
        }
        public async Task<ActivityType> Update(int id, ActivityType activityType)
        {
            if (activityType == null)
                return null;

            _context.Entry(activityType).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return await Get(id);
        }

       
    }
}
