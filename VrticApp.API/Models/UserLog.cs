using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class UserLog
    {
        [Key]
        public int UserLogId { get; set; }

        [ForeignKey(nameof(User)), Range(1, int.MaxValue), Required]
        public int UserId { get; set; }

        public string Activity { get; set; }

        public string Form { get; set; }

        public DateTime Date { get; set; }

        public User User { get; set; }
    }
}
