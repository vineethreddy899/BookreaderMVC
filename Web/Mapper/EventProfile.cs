using AutoMapper;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Mapper
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Event, EventModel>().ReverseMap();
            CreateMap<SignUp, SignUpModel>().ReverseMap();
            CreateMap<Login, LoginModel>().ReverseMap();
            CreateMap<Comment, CommentModel>().ReverseMap();
        }
    }
}
