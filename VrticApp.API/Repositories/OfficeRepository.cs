using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class OfficeRepository : IOfficeRepository
    {
        public Task<Office> Add(Office office)
        {
            throw new NotImplementedException();
        }

        public Task<List<Office>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<Office>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Office> Update(int id, Office office)
        {
            throw new NotImplementedException();
        }
    }
}
