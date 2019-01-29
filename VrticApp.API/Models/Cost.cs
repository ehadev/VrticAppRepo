using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class Cost
    {
        [Key]
        public int CostId { get; set; }

        [ForeignKey(nameof(User)), Range(1, int.MaxValue), Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(CostType)), Range(1, int.MaxValue), Required]
        public int CostTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public DateTime DateOfPayment { get; set; }

        public decimal Amount { get; set; }

        public int UserPaid { get; set; }

        public bool IsPaid { get; set; }

        public User User { get; set; }

        public CostType CostType { get; set; }

    }
}
