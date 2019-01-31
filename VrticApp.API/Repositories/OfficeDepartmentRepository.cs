using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class OfficeDepartmentRepository : IOfficeDepartmentRepository
    {
        public Task<OfficeDepartment> Add(OfficeDepartment officeDepartment)
        {
            throw new NotImplementedException();
        }

        public Task<List<OfficeDepartment>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<OfficeDepartment>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OfficeDepartment> Update(int id, OfficeDepartment officeDepartment)
        {
            throw new NotImplementedException();
        }
    }
}
