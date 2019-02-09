using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.DTOs.Grade
{
    public class GradeCreateDTO
    {
        public int GradeId { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
