using Dragon.Data.Context;
using Dragon.Domain.Interfaces.Repositories;
using Dragon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dragon.Data.Repository
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
