using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class ChildMembership
    {
        [Key]
        public int ChildMembershipId { get; set; }

        [ForeignKey(nameof(Child)), Range(1, int.MaxValue), Required]
        public int ChildId { get; set; }

        [ForeignKey(nameof(MembershipType)), Range(1, int.MaxValue), Required]
        public int MembershipTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDeadline { get; set; }

        public DateTime PaymentDate { get; set; }

        public bool IsPaid { get; set; }

        public bool IsActive { get; set; }

        public Child Child { get; set; }

        public MembershipType MembershipType { get; set; }

    }
}
