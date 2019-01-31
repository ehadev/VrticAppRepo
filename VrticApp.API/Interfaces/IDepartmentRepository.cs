using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> Get();
        Task<List<Department>> Get(int id);
        Task<Department> Add(Department department);
        Task<Department> Update(int id, Department department);
    }
}
