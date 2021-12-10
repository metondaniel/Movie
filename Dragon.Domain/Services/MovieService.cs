using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Services
{
    public class MovieService : ServiceBase<Movie>, IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository): base(movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<Movie> GetByParam(Movie movie)
        {
            if (movie == null)
            {
                movie = new Movie();
            }
            return _movieRepository.GetByParam(movie.Description,movie.Category);
        }

        public Movie GetById(Guid id)
        {
            return _movieRepository.GetById(id);
        }
    }
}
