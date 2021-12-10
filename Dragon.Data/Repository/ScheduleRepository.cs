using ProjetoDaniel.Data.Context;
using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoDaniel.Data.Repository
{
    public class ScheduleRepository : RepositoryBase<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public Schedule GetById(Guid Id)
        {
            var movie = Db.Set<Schedule>().FirstOrDefault(x => x.Id == Id);
            return movie;
        }
    }
}
