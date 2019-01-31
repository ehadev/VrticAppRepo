using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IMembershipTypeRepository
    {
        Task<List<MembershipType>> Get();
        Task<List<MembershipType>> Get(int id);
        Task<MembershipType> Add(MembershipType membershipType);
        Task<MembershipType> Update(int id, MembershipType membershipType);
    }
}
