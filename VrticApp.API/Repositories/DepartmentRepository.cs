using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public Task<Department> Add(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Department> Update(int id, Department department)
        {
            throw new NotImplementedException();
        }
    }
}
