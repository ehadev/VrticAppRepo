using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class UserActivity
    {
        [Key]
        public int UserActivityId { get; set; }

        [ForeignKey(nameof(User)), Range(1, int.MaxValue), Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(Activity)), Range(1, int.MaxValue), Required]
        public int ActivityId { get; set; }

        public User User { get; set; }

        public Activity Activity { get; set; }

    }
}
