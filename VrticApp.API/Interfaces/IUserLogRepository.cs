using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IUserLogRepository
    {
        Task<List<UserLog>> Get();
        Task<List<UserLog>> Get(int id);
        Task<UserLog> Add(UserLog userLog);
        Task<UserLog> Update(int id, UserLog userLog);
    }
}
