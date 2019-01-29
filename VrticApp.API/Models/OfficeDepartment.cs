using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class OfficeDepartment
    {
        [Key]
        public int OfficeDepartmentId { get; set; }

        [ForeignKey(nameof(Department)), Range(1, int.MaxValue), Required]
        public int DepartmentId { get; set; }

        [ForeignKey(nameof(Office)), Range(1, int.MaxValue), Required]
        public int OfficeId { get; set; }

        public Department Department { get; set; }

        public Office Office { get; set; }
    }
}
