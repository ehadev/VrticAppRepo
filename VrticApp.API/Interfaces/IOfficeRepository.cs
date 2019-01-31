using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IOfficeRepository
    {
        Task<List<Office>> Get();
        Task<List<Office>> Get(int id);
        Task<Office> Add(Office office);
        Task<Office> Update(int id, Office office);
    }
}
