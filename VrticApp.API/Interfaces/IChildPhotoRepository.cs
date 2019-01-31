using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IChildPhotoRepository
    {
        Task<List<ChildPhoto>> Get();
        Task<List<ChildPhoto>> Get(int id);
        Task<ChildPhoto> Add(ChildPhoto childPhoto);
        Task<ChildPhoto> Update(int id, ChildPhoto childPhoto);
    }
}
