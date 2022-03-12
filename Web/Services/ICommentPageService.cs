using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public interface ICommentPageService
    {
        Task<IList<CommentModel>> GetComments();
        Task<int> PostComment(CommentModel commentViewModel);
        Task<CommentModel> ViewComment(int commentId);
    }
}