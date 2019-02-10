using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VrticApp.API.DTOs.ActivityComment
{
    public class ActivityCommentGetDTO
    {
        public int ActivityCommentId { get; set; }
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool IsNotified { get; set; }
        public bool IsActive { get; set; }

       
    }
}
