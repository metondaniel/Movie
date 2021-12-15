using AutoMapper;
using Dragon.Domain.Interfaces.Services;
using Dragon.Dto;
using Dragon.Model;
using DragonApplication.Interfaces;
using Dragon.Domain.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragonApplication.Services
{
    public class ScheduleAppService : IScheduleAppService
    {
        private readonly IScheduleService _service;
        private readonly IMapper _mapper;
        public ScheduleAppService(IScheduleService ScheduleService, IMapper mapper)
        {
            _service = ScheduleService;
            _mapper = mapper;
        }

        public void DeleteSchedule(Guid scheduleId)
        {
            _service.Delete(_service.GetById(scheduleId));
        }
        public ScheduleDto GetScheduleById(Guid id)
        {
            return _mapper.Map<ScheduleDto>(_service.GetById(id));
        }

        public ScheduleDto SaveSchedule(ScheduleDto dtoRequest)
        {
            var ScheduleBuilder = new ScheduleBuilder()
                .WithSchedule(dtoRequest.ScheduleTime);
            return _mapper.Map<ScheduleDto>(_service.Add(ScheduleBuilder.Instance));
        }

        public void UpdateSchedule(ScheduleDto dtoRequest)
        {
            var ScheduleBuilder = new ScheduleBuilder()
                .WithId(dtoRequest.Id)
                .WithSchedule(dtoRequest.ScheduleTime);
            _service.Update(ScheduleBuilder.Instance);
        }
    }
}
