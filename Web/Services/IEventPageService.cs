using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public interface IEventPageService
    {
        Task<int> CreateEvent(EventModel eventModel);
        Task<IList<EventModel>> GetEvents();
        int UpdateEvent(EventModel eventModel);
        Task<EventModel> ViewDetails(int eventId);
        Task<IList<EventModel>> MyEvents(string organiser);
        Task<IList<CommentModel>> GetAllCommentByEventId(int eventId);
    }
}