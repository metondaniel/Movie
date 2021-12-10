using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Services
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
