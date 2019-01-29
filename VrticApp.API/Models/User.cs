using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class User: IdentityUser<int>
    {
        public string PhotoURL { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public bool IsActive { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

    }
}
