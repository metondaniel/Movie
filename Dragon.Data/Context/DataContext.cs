using Microsoft.EntityFrameworkCore;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Movie>()
            .HasKey(pr => new { pr.Id });

            builder.Entity<Schedule>()
            .HasKey(re => new { re.Id });

            builder.Entity<Movie>()
               .HasOne(re => re.ScheduleTime);


        }

    }
    }
