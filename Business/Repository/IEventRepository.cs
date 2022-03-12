using Business.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository
{
    public interface IEventRepository
    {
        Task<int> CreateEvent(Event _event);
        Task<IList<Event>> GetEvents();
        int UpdateEvent(Event _event);
        Task<Event> ViewDetails(int eventId);
        Task<IList<Event>> MyEvents(string Organiser);
        Task<IList<Comment>> GetAllCommentByEventId(int eventId);
    }
}