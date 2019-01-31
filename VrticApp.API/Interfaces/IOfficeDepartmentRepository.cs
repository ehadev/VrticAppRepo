using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IOfficeDepartmentRepository
    {
        Task<List<OfficeDepartment>> Get();
        Task<List<OfficeDepartment>> Get(int id);
        Task<OfficeDepartment> Add(OfficeDepartment officeDepartment);
        Task<OfficeDepartment> Update(int id, OfficeDepartment officeDepartment);
    }
}
