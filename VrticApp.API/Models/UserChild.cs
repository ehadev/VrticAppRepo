using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class UserChild
    {
        [Key]
        public int UserChildId { get; set; }

        [ForeignKey(nameof(User)), Range(1, int.MaxValue), Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(Child)), Range(1, int.MaxValue), Required]
        public int ChildId { get; set; }

        public Child Child { get; set; }

        public User User { get; set; }
    }
}
