using Dragon.Data.Context;
using Dragon.Domain.Interfaces.Repositories;
using Dragon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dragon.Data.Repository
{
    public class MovieRepository : RepositoryBase<Movie>, IMovieRepository
    {
        private readonly DataContext context;
        public MovieRepository(DataContext dataContext) : base(dataContext)
        {
            context = dataContext;
        }

        public Movie GetById(Guid Id)
        {
            var movie = Db.Set<Movie>().FirstOrDefault(x => x.Id == Id);
            return movie;
        }

        public List<Movie> GetByParam(string description,string category)
        {
            var movie = Db.Set<Movie>().Where(x => !string.IsNullOrEmpty(description) ? x.Description  == description: true && !string.IsNullOrEmpty(category) ? x.Category == category : true);
            return movie.ToList();
        }
    }
}
