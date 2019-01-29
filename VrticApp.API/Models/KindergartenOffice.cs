using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class KindergartenOffice
    {
        [Key]
        public int KindergartenOfficeId { get; set; }

        [ForeignKey(nameof(Kindergarten)),Range(1,int.MaxValue),Required]
        public int KindergartenId { get; set; }

        [ForeignKey(nameof(Office)), Range(1, int.MaxValue), Required]
        public int OfficeId { get; set; }

        public Kindergarten Kindergarten { get; set; }

        public Office Office { get; set; }


    }
}
