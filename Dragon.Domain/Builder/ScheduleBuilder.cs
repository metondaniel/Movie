using Dragon.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dragon.Domain.Builder
{
    public class ScheduleBuilder
    {
        public Schedule Instance = new Schedule();
        public ScheduleBuilder()
        {
            Instance.Id = Guid.NewGuid();
        }

        public ScheduleBuilder WithId(Guid id)
        {
            Instance.Id = id;
            return this;
        }

        public ScheduleBuilder WithSchedule(DateTime scheduleTime)
        {
            Instance.ScheduleTime = scheduleTime;
            return this;
        }
       
    }
}
