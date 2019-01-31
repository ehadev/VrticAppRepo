using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class UserActivityRepository : IUserActivityRepository
    {
        public Task<UserActivity> Add(UserActivity userActivity)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserActivity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserActivity>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserActivity> Update(int id, UserActivity userActivity)
        {
            throw new NotImplementedException();
        }
    }
}
