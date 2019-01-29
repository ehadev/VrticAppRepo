using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        [ForeignKey(nameof(User)), Range(1, int.MaxValue), Required]
        public int UserId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsNotified { get; set; }

        public User User { get; set; }
    }
}
