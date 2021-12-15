using Dragon.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dragon.Domain.Interfaces.Services
{
    public interface IScheduleService: IServiceBase<Schedule>
    {
        Schedule GetById(Guid Id);
    }
}
