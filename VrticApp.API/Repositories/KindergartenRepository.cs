using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class KindergartenRepository : IKindergartenRepository
    {
        public Task<Kindergarten> Add(Kindergarten kindergarten)
        {
            throw new NotImplementedException();
        }

        public Task<List<Kindergarten>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<Kindergarten>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Kindergarten> Update(int id, Kindergarten kindergarten)
        {
            throw new NotImplementedException();
        }
    }
}
