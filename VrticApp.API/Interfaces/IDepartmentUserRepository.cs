using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IDepartmentUserRepository
    {
        Task<List<DepartmentUser>> Get();
        Task<List<DepartmentUser>> Get(int id);
        Task<DepartmentUser> Add(DepartmentUser departmentUser);
        Task<DepartmentUser> Update(int id, DepartmentUser departmentUser);
    }
}
