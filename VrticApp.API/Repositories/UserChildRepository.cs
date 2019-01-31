using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class UserChildRepository : IUserChildRepository
    {
        public Task<UserChild> Add(UserChild userChild)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserChild>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserChild>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserChild> Update(int id, UserChild userChild)
        {
            throw new NotImplementedException();
        }
    }
}
