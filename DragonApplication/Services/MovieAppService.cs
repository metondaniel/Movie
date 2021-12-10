using AutoMapper;
using ProjetoDaniel.Domain.Builder;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Dto;
using ProjetoDaniel.Model;
using ProjetoDanielApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Services
{
    public class MovieAppService : IMovieAppService
    {
        private readonly IMovieService _service;
        private readonly IMapper _mapper;
        public MovieAppService(IMovieService movieService, IMapper mapper)
        {
            _service = movieService;
            _mapper = mapper;
        }

        public void DeleteMovie(Guid MovieId)
        {
            _service.Delete(_service.GetById(MovieId));
        }

        public List<MovieDto> GetMovie(MovieDto dtoRequest)
        {
            return _mapper.Map<List<MovieDto>>(_service.GetByParam(
                _mapper.Map<Movie>(dtoRequest)));
        }

        public MovieDto GetMovieById(Guid id)
        {
            return _mapper.Map<MovieDto>(_service.GetById(id));
        }

        public MovieDto SaveMovie(MovieDto dtoRequest)
        {
            var movieBuilder = new MovieBuilder()
                .WithDescription(dtoRequest.Description)
                .WithCategory(dtoRequest.Category)
                .WithSchedule(_mapper.Map<Schedule>(dtoRequest.ScheduleDto));
            return _mapper.Map<MovieDto>(_service.Add(movieBuilder.Instance));
        }

        public void UpdateMovie(MovieDto dtoRequest)
        {
            var movieBuilder = new MovieBuilder()
                .WithDescription(dtoRequest.Description)
                .WithCategory(dtoRequest.Category)
                .WithSchedule(_mapper.Map<Schedule>(dtoRequest.ScheduleDto));
            _service.Update(movieBuilder.Instance);
        }
    }
}
