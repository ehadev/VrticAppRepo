using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ChildMembershipRepository : IChildMembershipRepository
    {
        public Task<ChildMembership> Add(ChildMembership childMembership)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChildMembership>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<ChildMembership>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ChildMembership> Update(int id, ChildMembership childMembership)
        {
            throw new NotImplementedException();
        }
    }
}
