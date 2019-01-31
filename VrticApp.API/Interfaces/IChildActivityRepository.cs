using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IChildActivityRepository
    {
        Task<List<ChildActivity>> Get();
        Task<List<ChildActivity>> Get(int id);
        Task<ChildActivity> Add(ChildActivity childActivity);
        Task<ChildActivity> Update(int id, ChildActivity childActivity);
    }
}
