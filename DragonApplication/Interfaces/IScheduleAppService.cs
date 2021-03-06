using Dragon.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DragonApplication.Interfaces
{
    public interface IScheduleAppService
    {

        ScheduleDto GetScheduleById(Guid id);

        ScheduleDto SaveSchedule(ScheduleDto dtoRequest);

        void UpdateSchedule(ScheduleDto dtoRequest);

        void DeleteSchedule(Guid ScheduleId);
    }
}
