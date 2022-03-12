using AutoMapper;
using Business.Entities;
using Business.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;


namespace Web.Services
{
    public class EventPageService : IEventPageService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventPageService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<IList<EventModel>> GetEvents()
        {
            var list = await _eventRepository.GetEvents();
            var mapped = _mapper.Map<IList<EventModel>>(list);
            return mapped;
        }

        public async Task<EventModel> ViewDetails(int eventId)
        {
            var _event = await _eventRepository.ViewDetails(eventId);
            var mapped = _mapper.Map<EventModel>(_event);
            return mapped;
        }

        public async Task<int> CreateEvent(EventModel eventModel)
        {
            var mapped = _mapper.Map<Event>(eventModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");
            return await _eventRepository.CreateEvent(mapped);
        }

        public int UpdateEvent(EventModel eventModel)
        {
            var mapped = _mapper.Map<Event>(eventModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");
            return _eventRepository.UpdateEvent(mapped);
        }

        public async Task<IList<EventModel>> MyEvents(string organiser)
        {
            var eventList = await _eventRepository.MyEvents(organiser);
            var mapped = _mapper.Map<IList<EventModel>>(eventList);
            return mapped;

        }

        public async Task<IList<CommentModel>> GetAllCommentByEventId(int eventId)
        {
            var commentList = await _eventRepository.GetAllCommentByEventId(eventId);
            var mapped = _mapper.Map<IList<CommentModel>>(commentList);
            return mapped;
        }
    }
}
