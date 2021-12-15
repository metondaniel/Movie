using System;
using System.Collections.Generic;
using System.Text;

namespace Dragon.Dto
{
    public class MovieDto
    {
        public Guid Id { get; }

        public byte[] Poster { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public ScheduleDto ScheduleDto { get; set; }
    }
}
