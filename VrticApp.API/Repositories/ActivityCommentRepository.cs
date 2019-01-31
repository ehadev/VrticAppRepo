using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ActivityCommentRepository : IActivityCommentRepository
    {
        public Task<ActivityComment> Add(ActivityComment activityComment)
        {
            throw new NotImplementedException();
        }

        public Task<List<ActivityComment>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<ActivityComment>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActivityComment> Update(int id, ActivityComment activityComment)
        {
            throw new NotImplementedException();
        }
    }
}
