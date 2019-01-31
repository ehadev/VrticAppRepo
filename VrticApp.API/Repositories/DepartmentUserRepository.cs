using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class DepartmentUserRepository : IDepartmentUserRepository
    {
        public Task<DepartmentUser> Add(DepartmentUser departmentUser)
        {
            throw new NotImplementedException();
        }

        public Task<List<DepartmentUser>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<DepartmentUser>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentUser> Update(int id, DepartmentUser departmentUser)
        {
            throw new NotImplementedException();
        }
    }
}
