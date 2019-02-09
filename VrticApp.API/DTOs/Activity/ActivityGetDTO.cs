using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.DTOs.Activity
{
    public class ActivityGetDTO
    {
        public int ActivityId { get; set; }

        public int ActivityTypeId { get; set; }

        public int DifficultyLevelId { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Duration { get; set; }

        public DateTime Date { get; set; }

        public bool IsActive { get; set; }

    }
}
