using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.DTOs.CostType;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface ICostTypeRepository
    {
        Task<List<CostType>> Get();
        Task<CostType> Get(int id);
        Task<CostType> Add(CostTypeCreateDTO costType);
        Task<CostType> Update(int id, CostTypeUpdateDTO costType);
    }
}
