using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.DTOs.DifficultyLevel;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IDifficultyLevelRepository
    {
        Task<List<DifficultyLevelGetDTO>> Get();
        Task<DifficultyLevelGetDTO> Get(int id);
        Task<DifficultyLevelGetDTO> Add(DifficultyLevelCreateDTO difficultyLevel);
        Task<DifficultyLevelGetDTO> Update(int id, DifficultyLevelUpdateDTO difficultyLevel);
    }
}
