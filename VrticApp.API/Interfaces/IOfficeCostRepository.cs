using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IOfficeCostRepository
    {
        Task<List<OfficeCost>> Get();
        Task<List<OfficeCost>> Get(int id);
        Task<OfficeCost> Add(OfficeCost officeCost);
        Task<OfficeCost> Update(int id, OfficeCost officeCost);
    }
}
