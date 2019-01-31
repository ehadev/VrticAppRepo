using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class CostRepository : ICostRepository
    {
        public Task<Cost> Add(Cost cost)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cost>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<Cost>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cost> Update(int id, Cost cost)
        {
            throw new NotImplementedException();
        }
    }
}
