using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IGradeRepository
    {
        Task<List<Grade>> Get();
        Task<List<Grade>> Get(int id);
        Task<Grade> Add(Grade grade);
        Task<Grade> Update(int id, Grade grade);
    }
}
