using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly MyContext _context;

        public ActivityRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Activity>> Get()
        {
            return await _context.Activities.AnyAsync() ?
                   await _context.Activities.Include(x => x.ActivityType)
                                            .Include(x => x.DifficultyLevel)
                                            .ToListAsync() : null;
        }

        public async Task<Activity> Get(int id)
        {

            return await _context.Activities.AnyAsync() ?
                   await _context.Activities.Include(x => x.ActivityType)
                                           .Include(x => x.DifficultyLevel)
                                           .Where(x=>x.ActivityId == id)
                                           .FirstOrDefaultAsync() : null;
        }

        public async Task<Activity> Add(Activity activity)
        {
            if (activity == null)
                return null;

            await _context.Activities.AddAsync(activity);
            await _context.SaveChangesAsync();

            return activity;
        }
        public async Task<Activity> Update(int id, Activity activity)
        {
            //Edit 
            if (activity == null)
                return null;

            var activityEntity = await _context.Activities.Where(x => x.ActivityId == id)
                                                          .FirstOrDefaultAsync();

            if (activityEntity == null)
                return null;

            _context.Entry(activity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return activityEntity;
        }
    }
}
