using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class OfficeCost
    {
        [Key]
        public int OfficeCostId { get; set; }

        [ForeignKey(nameof(Office)), Range(1, int.MaxValue), Required]
        public int OfficeId { get; set; }

        [ForeignKey(nameof(Cost)), Range(1, int.MaxValue), Required]
        public int CostId { get; set; }

        public Cost Cost { get; set; }

        public Office Office { get; set; }

    }
}
