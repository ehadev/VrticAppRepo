using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.DTOs.ActivityType;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IActivityTypeRepository
    {
        Task<List<ActivityType>> Get();
        Task<ActivityType> Get(int id);
        Task<ActivityType> Add(ActivityType activityType);
        Task<ActivityType> Update(int id, ActivityType activityType);
    }
}
