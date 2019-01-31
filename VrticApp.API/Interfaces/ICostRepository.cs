using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface ICostRepository
    {
        Task<List<Cost>> Get();
        Task<List<Cost>> Get(int id);
        Task<Cost> Add(Cost cost);
        Task<Cost> Update(int id, Cost cost);
    }
}
