using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.DTOs.Grade;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IGradeRepository: IRepository<Grade>
    {
        Task<Grade> Add(GradeCreateDTO grade);
        Task<Grade> Update(int id, GradeUpdateDTO grade);
    }
}
