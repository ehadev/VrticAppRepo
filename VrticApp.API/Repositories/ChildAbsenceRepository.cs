using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ChildAbsenceRepository : IChildAbsenceRepository
    {
        public Task<ChildAbsence> Add(ChildAbsence childAbsence)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChildAbsence>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<ChildAbsence>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ChildAbsence> Update(int id, ChildAbsence childAbsence)
        {
            throw new NotImplementedException();
        }
    }
}
