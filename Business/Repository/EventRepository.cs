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
    public class EventRepository : IEventRepository
    {
        private readonly EventContext _eventContext;

        public EventRepository(EventContext eventContext)
        {
            _eventContext = eventContext;
        }

        public async Task<IList<Event>> GetEvents()
        {
            return await _eventContext.Events.OrderBy(x => x.Date).ToListAsync();
        }

        public async Task<Event> ViewDetails(int eventId)
        {
            return await _eventContext.Events.FindAsync(eventId);
        }

        public async Task<int> CreateEvent(Event _event)
        {
            var newEvent = new Event()
            {
                Title = _event.Title,
                Description = _event.Description,
                Date = _event.Date,
                Location = _event.Location,
                Organiser=_event.Organiser,
                Duration = _event.Duration,
                Type = _event.Type,
                OtherDetails = _event.OtherDetails,
                Invitees = _event.Invitees
            };
            await _eventContext.Events.AddAsync(newEvent);
            await _eventContext.SaveChangesAsync();

            return newEvent.Id;

        }

        public int UpdateEvent(Event _event)
        {
            _eventContext.Events.Update(_event);
            _eventContext.SaveChanges();
            return _event.Id;
        }

        public async Task<IList<Event>> MyEvents(string Organiser)
        {
            var result = from _event in _eventContext.Events
                         where _event.Organiser == Organiser
                         orderby _event.Date
                         select _event;
            return await result.ToListAsync();
        }

        public async Task<IList<Comment>> GetAllCommentByEventId(int eventId)
        {
            var result = await (from e in _eventContext.Events
                                join c in _eventContext.Comment on
                                e.Id equals c.EventId
                                where c.EventId == eventId
                                orderby c.TimeStamp
                                select new Comment()
                                {
                                    EventId = eventId,
                                    Comments = c.Comments,
                                    TimeStamp = c.TimeStamp

                                }).ToListAsync();
            return result;
        }
    }
}
