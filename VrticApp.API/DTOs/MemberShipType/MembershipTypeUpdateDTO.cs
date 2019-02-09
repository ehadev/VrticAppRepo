using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.DTOs.MemberShipType
{
    public class MembershipTypeUpdateDTO
    {
        public int MembershipTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
