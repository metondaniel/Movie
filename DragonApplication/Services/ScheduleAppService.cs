using AutoMapper;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Dto;
using ProjetoDaniel.Model;
using ProjetoDanielApplication.Interfaces;
using ProjetoDaniel.Domain.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Services
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
