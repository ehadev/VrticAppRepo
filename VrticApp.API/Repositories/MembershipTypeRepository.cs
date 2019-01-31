using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class MembershipTypeRepository : IMembershipTypeRepository
    {
        public Task<MembershipType> Add(MembershipType membershipType)
        {
            throw new NotImplementedException();
        }

        public Task<List<MembershipType>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<List<MembershipType>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MembershipType> Update(int id, MembershipType membershipType)
        {
            throw new NotImplementedException();
        }
    }
}
