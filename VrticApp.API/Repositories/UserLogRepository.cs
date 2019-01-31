using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class UserLogRepository : IUserLogRepository
    {
        public Task<UserLog> Add(UserLog userLog)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserLog>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserLog>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserLog> Update(int id, UserLog userLog)
        {
            throw new NotImplementedException();
        }
    }
}
