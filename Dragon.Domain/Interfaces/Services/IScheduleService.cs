using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Services
{
    public interface IScheduleService: IServiceBase<Schedule>
    {
        Schedule GetById(Guid Id);
    }
}
