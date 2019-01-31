using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        public Task<Grade> Add(Grade grade)
        {
            throw new NotImplementedException();
        }

        public Task<List<Grade>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<Grade>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Grade> Update(int id, Grade grade)
        {
            throw new NotImplementedException();
        }
    }
}
