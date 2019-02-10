using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.DTOs.ActivityComment;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IActivityCommentRepository
    {
        Task<IEnumerable<ActivityComment>> Get();
        Task<ActivityComment> Get(int id);
        Task<ActivityComment> Add(ActivityCommentCreateDTO activityComment);
        Task<ActivityComment> Update(int id, ActivityComment activityComment);
    }
}
