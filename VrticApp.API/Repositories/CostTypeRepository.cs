using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class CostTypeRepository : ICostTypeRepository
    {
        public Task<CostType> Add(CostType costType)
        {
            throw new NotImplementedException();
        }

        public Task<List<CostType>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<CostType>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CostType> Update(int id, CostType costType)
        {
            throw new NotImplementedException();
        }
    }
}
