using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.DTOs.MemberShipType;
using VrticApp.API.Models;

namespace VrticApp.API.Interfaces
{
    public interface IMembershipTypeRepository
    {
        Task<List<MembershipTypeGetDTO>> Get();
        Task<MembershipTypeGetDTO> Get(int id);
        Task<MembershipTypeGetDTO> Add(MembershipTypeCreateDTO membershipType);
        Task<MembershipTypeGetDTO> Update(int id, MembershipTypeUpdateDTO membershipType);
    }
}
