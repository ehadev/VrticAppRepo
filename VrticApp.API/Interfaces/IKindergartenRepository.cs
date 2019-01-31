using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IKindergartenRepository
    {
        Task<List<Kindergarten>> Get();
        Task<List<Kindergarten>> Get(int id);
        Task<Kindergarten> Add(Kindergarten kindergarten);
        Task<Kindergarten> Update(int id, Kindergarten kindergarten);
    }
}
