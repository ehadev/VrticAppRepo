using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IActivityCommentRepository
    {
        Task<List<ActivityComment>> Get();
        Task<List<ActivityComment>> Get(int id);
        Task<ActivityComment> Add(ActivityComment activityComment);
        Task<ActivityComment> Update(int id, ActivityComment activityComment);
    }
}
