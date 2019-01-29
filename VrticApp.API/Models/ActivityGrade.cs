using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class ActivityGrade
    {
        [Key]
        public int ActivityGradeId { get; set; }

        [ForeignKey(nameof(Child)), Range(1, int.MaxValue), Required]
        public int ChildId { get; set; }

        [ForeignKey(nameof(Activity)), Range(1, int.MaxValue), Required]
        public int ActivityId { get; set; }

        [ForeignKey(nameof(Grade)), Range(1, int.MaxValue), Required]
        public int GradeId { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public Activity Activity { get; set; }

        public Child Child { get; set; }

        public Grade Grade { get; set; }


    }
}
