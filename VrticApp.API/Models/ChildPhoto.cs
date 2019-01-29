﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.Models
{
    public class ChildPhoto
    {
        [Key]
        public int ChildPhotoId { get; set; }

        public DateTime Date { get; set; }

        public string PhotoURL { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

    }
}