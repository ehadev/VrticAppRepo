using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IChildAbsenceRepository
    {
        Task<List<ChildAbsence>> Get();
        Task<List<ChildAbsence>> Get(int id);
        Task<ChildAbsence> Add(ChildAbsence childAbsence);
        Task<ChildAbsence> Update(int id, ChildAbsence childAbsence);
    }
}
