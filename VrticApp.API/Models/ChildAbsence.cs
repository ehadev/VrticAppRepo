using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class ChildAbsence
    {
        [Key]
        public int ChildAbsenceId { get; set; }

        [ForeignKey(nameof(User)), Range(1, int.MaxValue), Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(Child)), Range(1, int.MaxValue), Required]
        public int ChildId { get; set; }

        public DateTime Date { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public string Reason { get; set; }

        public bool IsActive { get; set; }

        public bool IsNotified { get; set; }

        public User User { get; set; }

        public Child Child { get; set; }
    }
}
