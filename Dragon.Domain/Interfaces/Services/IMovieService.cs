using Dragon.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dragon.Domain.Interfaces.Services
{
    public interface IMovieService: IServiceBase<Movie>
    {
        List<Movie> GetByParam(Movie movie);

        Movie GetById(Guid Id);
    }
}
