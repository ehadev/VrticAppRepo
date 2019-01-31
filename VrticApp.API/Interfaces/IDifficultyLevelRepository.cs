using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IDifficultyLevelRepository
    {
        Task<List<DifficultyLevel>> Get();
        Task<List<DifficultyLevel>> Get(int id);
        Task<DifficultyLevel> Add(DifficultyLevel difficultyLevel);
        Task<DifficultyLevel> Update(int id, DifficultyLevel difficultyLevel);
    }
}
