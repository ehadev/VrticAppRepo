using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ChildPhotoRepository : IChildPhotoRepository
    {
        public Task<ChildPhoto> Add(ChildPhoto childPhoto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChildPhoto>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<ChildPhoto>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ChildPhoto> Update(int id, ChildPhoto childPhoto)
        {
            throw new NotImplementedException();
        }
    }
}
