using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ActivityTypeRepository : IActivityTypeRepository
    {
        public Task<ActivityType> Add(ActivityType activityType)
        {
            throw new NotImplementedException();
        }

        public Task<List<ActivityType>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<ActivityType>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActivityType> Update(int id, ActivityType activityType)
        {
            throw new NotImplementedException();
        }
    }
}
