using Dragon.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dragon.Domain.Interfaces.Repositories
{
    public interface IScheduleRepository : IRepositoryBase<Schedule>
    {

        Schedule GetById(Guid Id);
    }
}
