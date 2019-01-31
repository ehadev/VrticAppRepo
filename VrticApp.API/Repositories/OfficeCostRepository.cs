using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class OfficeCostRepository : IOfficeCostRepository
    {
        public Task<OfficeCost> Add(OfficeCost officeCost)
        {
            throw new NotImplementedException();
        }

        public Task<List<OfficeCost>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<OfficeCost>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OfficeCost> Update(int id, OfficeCost officeCost)
        {
            throw new NotImplementedException();
        }
    }
}
