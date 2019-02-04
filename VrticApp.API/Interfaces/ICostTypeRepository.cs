using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface ICostTypeRepository
    {
        Task<List<CostType>> Get();
        Task<List<CostType>> Get(int id);
        Task<CostType> Add(CostType costType);
        Task<CostType> Update(int id, CostType costType);
    }
}
