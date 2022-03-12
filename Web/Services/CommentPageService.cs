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
    public class CommentPageService : ICommentPageService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentPageService(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public async Task<int> PostComment(CommentModel commentModel)
        {
            var mapped = _mapper.Map<Comment>(commentModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");
            return await _commentRepository.PostComment(mapped);
        }

        public async Task<IList<CommentModel>> GetComments()
        {
            var list = await _commentRepository.GetComments();
            var mapped = _mapper.Map<IList<CommentModel>>(list);
            return mapped;
        }

        public async Task<CommentModel> ViewComment(int commentId)
        {
            var _comment = await _commentRepository.ViewComment(commentId);
            var mapped = _mapper.Map<CommentModel>(_comment);
            return mapped;
        }

       
    }
}
