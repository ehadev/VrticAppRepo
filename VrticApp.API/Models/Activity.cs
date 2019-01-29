using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        [ForeignKey(nameof(ActivityType)), Range(1, int.MaxValue), Required]
        public int ActivityTypeId { get; set; }

        [ForeignKey(nameof(DifficultyLevel)), Range(1, int.MaxValue), Required]
        public int DifficultyLevelId { get; set; }

        [ForeignKey(nameof(User)), Range(1, int.MaxValue), Required]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Duration { get; set; }

        public DateTime Date { get; set; }

        public bool IsActive { get; set; }

        public ActivityType ActivityType { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public User User { get; set; }

    }
}
