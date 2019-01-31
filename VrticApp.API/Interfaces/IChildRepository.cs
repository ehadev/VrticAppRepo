using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IChildRepository
    {
        Task<List<Child>> Get();
        Task<List<Child>> Get(int id);
        Task<Child> Add(Child child);
        Task<Child> Update(int id, Child child);
    }
}
