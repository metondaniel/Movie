using Dragon.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dragon.Domain.Interfaces.Repositories
{
    public interface IMovieRepository: IRepositoryBase<Movie>
    {
        List<Movie> GetByParam(string description,string category);

        Movie GetById(Guid Id);
    }
}
