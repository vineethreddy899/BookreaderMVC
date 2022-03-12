using Business.Data;
using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly EventContext _commentContext;

        public CommentRepository(EventContext commentContext)
        {
            _commentContext = commentContext;
        }
        public async Task<int> PostComment(Comment response)
        {
            var newComment = new Comment()
            {
                Comments = response.Comments,
                EventId = response.EventId
            };
            await _commentContext.Comment.AddAsync(newComment);
            await _commentContext.SaveChangesAsync();
            return newComment.Id;
        }

        public async Task<IList<Comment>> GetComments()
        {
            return await _commentContext.Comment.OrderByDescending(x => x.TimeStamp).ToListAsync();
        }
        public async Task<Comment> ViewComment(int commentId)
        {
            return await _commentContext.Comment.FindAsync(commentId);
        }
        
    }
}
