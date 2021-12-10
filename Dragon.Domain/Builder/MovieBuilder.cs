using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Builder
{
    public class MovieBuilder
    {
        public Movie Instance = new Movie();
        public MovieBuilder()
        {
            Instance.Id = Guid.NewGuid();
        }

        public MovieBuilder WithId(Guid id)
        {
            Instance.Id = id;
            return this;
        }

        public MovieBuilder WithDescription(string description)
        {
            Instance.Description = description;
            return this;
        }
        public MovieBuilder WithCategory(string category)
        {
            Instance.Category = category;
            return this;
        }
        public MovieBuilder WithSchedule(Schedule schedule)
        {
            Instance.ScheduleTime = schedule;
            return this;
        }
    }
}
