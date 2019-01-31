using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        public Task<Activity> Add(Activity activity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Activity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<Activity>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Activity> Update(int id, Activity activity)
        {
            throw new NotImplementedException();
        }
    }
}
