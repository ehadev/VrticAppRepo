using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class DeletedMessage
    {
        [Key]
        public int DeletedMessageId { get; set; }

        [ForeignKey(nameof(Kindergarten)), Range(1, int.MaxValue), Required]
        public int MessageId { get; set; }

        [ForeignKey(nameof(Kindergarten)), Range(1, int.MaxValue), Required]
        public int UserId { get; set; }

        public DateTime Date { get; set; }

        public User User { get; set; }

        public Message Message { get; set; }
    }
}
