using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class ChildActivity
    {
        [Key]
        public int ChildActivityId { get; set; }

        [ForeignKey(nameof(Child)), Range(1, int.MaxValue), Required]
        public int ChildId { get; set; }

        [ForeignKey(nameof(Activity)), Range(1, int.MaxValue), Required]
        public int ActivityId { get; set; }

        public Activity Activity { get; set; }

        public Child Child { get; set; }

    }
}
