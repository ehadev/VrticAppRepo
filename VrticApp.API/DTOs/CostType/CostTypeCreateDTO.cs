using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.DTOs.CostType
{
    public class CostTypeCreateDTO
    {
        public int CostTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
