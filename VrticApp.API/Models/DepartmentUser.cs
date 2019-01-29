using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class DepartmentUser
    {
        [Key]
        public int DepartmentUserId { get; set; }

        [ForeignKey(nameof(User)), Range(1, int.MaxValue), Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(Department)), Range(1, int.MaxValue), Required]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public User User { get; set; }

    }
}
