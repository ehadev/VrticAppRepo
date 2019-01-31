using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IUserActivityRepository
    {
        Task<List<UserActivity>> Get();
        Task<List<UserActivity>> Get(int id);
        Task<UserActivity> Add(UserActivity userActivity);
        Task<UserActivity> Update(int id, UserActivity userActivity);
    }
}
