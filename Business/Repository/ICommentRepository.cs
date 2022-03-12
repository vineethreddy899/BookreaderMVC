using Business.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository
{
    public interface ICommentRepository
    {
        Task<IList<Comment>> GetComments();
        Task<int> PostComment(Comment response);
        Task<Comment> ViewComment(int commentId);
    }
}