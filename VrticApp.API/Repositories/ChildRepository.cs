using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ChildRepository : IChildRepository
    {
        public Task<Child> Add(Child child)
        {
            throw new NotImplementedException();
        }

        public Task<List<Child>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<Child>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Child> Update(int id, Child child)
        {
            throw new NotImplementedException();
        }
    }
}
