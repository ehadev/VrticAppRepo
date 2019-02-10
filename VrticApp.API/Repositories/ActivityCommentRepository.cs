using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Contexts;
using VrticApp.API.DTOs.ActivityComment;
using VrticApp.API.Interfaces;
using VrticApp.API.Models;

namespace VrticApp.API.Repositories
{
    public class ActivityCommentRepository : IActivityCommentRepository
    {
        private readonly MyContext _context;

        public ActivityCommentRepository(MyContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ActivityComment>> Get()
        {
            return await _context.ActivityComments.Include(x => x.Activity).AnyAsync() ?
                   await _context.ActivityComments.Include(x => x.Activity).ToListAsync() : null;
        }
        public async Task<ActivityComment> Get(int id)
        {
            return await _context.ActivityComments.Include(x => x.Activity).AnyAsync() ?
                   await _context.ActivityComments.Include(x => x.Activity).Where(x=>x.ActivityCommentId==id).FirstOrDefaultAsync() : null;
        }
        public async Task<ActivityComment> Add(ActivityCommentCreateDTO activityComment)
        {
            if (activityComment == null)
                return null;
            ActivityComment aCommentObject = new ActivityComment
            {
                UserId = activityComment.UserId,
                ActivityId = activityComment.ActivityId,
                Content = activityComment.Content,
                Date = activityComment.Date,
                IsNotified = activityComment.IsNotified,
                IsActive = activityComment.IsActive
            };
            await _context.ActivityComments.AddAsync(aCommentObject);
            await _context.SaveChangesAsync();
            return await Get(activityComment.ActivityCommentId);
        }
        public async Task<ActivityComment> Update(int id, ActivityComment activityComment)
        {
            if (activityComment == null)
                return null;
            ActivityComment aComment = await _context.ActivityComments.Where(x => x.ActivityCommentId == id).FirstOrDefaultAsync();
            if (aComment == null)
                return null;

            //aComment.UserId = activityComment.UserId;
            //aComment.ActivityId = activityComment.ActivityId;
            //aComment.Content = activityComment.Content;
            //aComment.Date = activityComment.Date;
            //aComment.IsNotified = activityComment.IsNotified;
            //aComment.IsActive = activityComment.IsActive;

            _context.Entry(activityComment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return await Get(id);

        }
    }
}
