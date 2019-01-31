using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IChildMembershipRepository
    {
        Task<List<ChildMembership>> Get();
        Task<List<ChildMembership>> Get(int id);
        Task<ChildMembership> Add(ChildMembership childMembership);
        Task<ChildMembership> Update(int id, ChildMembership childMembership);
    }
}
