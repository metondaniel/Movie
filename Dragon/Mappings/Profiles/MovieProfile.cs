using AutoMapper;
using Dragon.Dto;
using Dragon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonWebApi.Mappings.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieDto, Movie>();
            CreateMap<Movie, MovieDto>().ForMember(x=>x.Schedule,y=>y.MapFrom(src => src.ScheduleTime.ScheduleTime.ToShortDateString()));
        }
    }
}
