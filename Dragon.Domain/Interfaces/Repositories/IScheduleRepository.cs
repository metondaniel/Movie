using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Repositories
{
    public interface IScheduleRepository : IRepositoryBase<Schedule>
    {

        Schedule GetById(Guid Id);
    }
}
