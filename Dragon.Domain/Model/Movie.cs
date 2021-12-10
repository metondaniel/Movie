using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDaniel.Model
{
    public class Movie
    {
        public Guid Id { get; set; }

        public byte[] Poster { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public Schedule ScheduleTime { get; set; }

    }
}
