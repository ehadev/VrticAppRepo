using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class DifficultyLevelRepository : IDifficultyLevelRepository
    {
        public Task<DifficultyLevel> Add(DifficultyLevel difficultyLevel)
        {
            throw new NotImplementedException();
        }

        public Task<List<DifficultyLevel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<DifficultyLevel>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DifficultyLevel> Update(int id, DifficultyLevel difficultyLevel)
        {
            throw new NotImplementedException();
        }
    }
}
