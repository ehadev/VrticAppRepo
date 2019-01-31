using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IActivityGradeRepository
    {
        Task<List<ActivityGrade>> Get();
        Task<List<ActivityGrade>> Get(int id);
        Task<ActivityGrade> Add(ActivityGrade activityGrade);
        Task<ActivityGrade> Update(int id, ActivityGrade activityGrade);
    }
}
