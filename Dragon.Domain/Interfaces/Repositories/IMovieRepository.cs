using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Repositories
{
    public interface IMovieRepository: IRepositoryBase<Movie>
    {
        List<Movie> GetByParam(string description,string category);

        Movie GetById(Guid Id);
    }
}
