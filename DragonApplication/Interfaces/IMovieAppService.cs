using ProjetoDaniel.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Interfaces
{
    public interface IMovieAppService
    {
        List<MovieDto> GetMovie(MovieDto dtoRequest);

        MovieDto GetMovieById(Guid id);

        MovieDto SaveMovie(MovieDto dtoRequest);

        void UpdateMovie(MovieDto dtoRequest);

        void DeleteMovie(Guid MovieId);
    }
}
