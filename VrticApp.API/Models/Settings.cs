using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class Settings
    {
        [Key]
        public int SettingsId { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

    }
}
