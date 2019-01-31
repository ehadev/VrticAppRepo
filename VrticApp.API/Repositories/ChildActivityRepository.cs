using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ChildActivityRepository : IChildActivityRepository
    {
        public Task<ChildActivity> Add(ChildActivity childActivity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChildActivity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<ChildActivity>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ChildActivity> Update(int id, ChildActivity childActivity)
        {
            throw new NotImplementedException();
        }
    }
}
