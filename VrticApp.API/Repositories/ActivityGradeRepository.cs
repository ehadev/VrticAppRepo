using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ActivityGradeRepository : IActivityGradeRepository
    {
        public Task<ActivityGrade> Add(ActivityGrade activityGrade)
        {
            throw new NotImplementedException();
        }

        public Task<List<ActivityGrade>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<ActivityGrade>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActivityGrade> Update(int id, ActivityGrade activityGrade)
        {
            throw new NotImplementedException();
        }
    }
}
