using Dragon.Domain.Interfaces.Repositories;
using Dragon.Domain.Interfaces.Services;
using Dragon.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dragon.Domain.Services
{
    public class ScheduleService : ServiceBase<Schedule>, IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleService(IScheduleRepository scheduleRepository) : base(scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        
        public Schedule GetById(Guid Id)
        {
            return _scheduleRepository.GetById(Id);
        }
    }
}
