using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IUserChildRepository
    {
        Task<List<UserChild>> Get();
        Task<List<UserChild>> Get(int id);
        Task<UserChild> Add(UserChild userChild);
        Task<UserChild> Update(int id, UserChild userChild);
    }
}
