using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.DTOs.Kindergarten
{
    public class KindergartenCreateDTO
    {
        public int KindergartenId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Web { get; set; }

        public string Owner { get; set; }

        public string LogoURL { get; set; }

        public bool IsDeleted { get; set; }
    }
}
