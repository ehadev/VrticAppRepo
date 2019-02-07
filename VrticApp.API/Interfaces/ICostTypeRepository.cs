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
        Task<List<CostTypeGetDTO>> Get();
        Task<CostTypeGetDTO> Get(int id);
        Task<CostTypeGetDTO> Add(CostTypeCreateDTO costType);
        Task<CostTypeGetDTO> Update(int id, CostTypeUpdateDTO costType);
    }
}
