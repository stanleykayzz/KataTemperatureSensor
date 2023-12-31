﻿using Microsoft.EntityFrameworkCore;
using TemperatureSensor.Entities;
using TemperatureSensor.Models;

namespace TemperatureSensor
{
    public class TemperatureInfoContext : DbContext
    {
        public DbSet<TemperatureInfo> TemperatureInfos { get; set; } = null!;
        public DbSet<StateLimit> StateLimits { get; set; } = null!;

        public TemperatureInfoContext(DbContextOptions<TemperatureInfoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StateLimit>()
                .HasData(
                new StateLimit()
                {
                    StateLimitsId = 1,
                    Name = "COLD",
                    Value = 19,
                },
                new StateLimit()
                {
                    StateLimitsId = 2,
                    Name = "WARM",
                    Value = 30,
                },
                new StateLimit()
                {
                    StateLimitsId = 3,
                    Name = "HOT",
                    Value = 30,
                }
                ); ;
            modelBuilder.Entity<TemperatureInfo>()
                .HasData(
                new TemperatureInfo()
                {
                    Id = 1,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,                  
                },
                new TemperatureInfo()
                {
                    Id = 2,
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 3,
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 4,
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 5,
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 6,
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 7,
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 8,
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 9,
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },

                new TemperatureInfo()
                {
                    Id = 10,
                    Temperature = 8,
                    State = "COLD",
                    Date = DateTime.Now,
                },

                new TemperatureInfo()
                {
                    Id = 11,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 12,
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 13,
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 14,
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 15,
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },

                new TemperatureInfo()
                {
                    Id = 16,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 17,
                    Temperature = 2,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 18,
                    Temperature = 6,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 19,
                    Temperature = 40,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 20,
                    Temperature = 25,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 21,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 22,
                    Temperature = 47,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 23,
                    Temperature = 38,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 24,
                    Temperature = 14,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 25,
                    Temperature = 15,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 26,
                    Temperature = 36,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 27,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 28,
                    Temperature = 27,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfo()
                {
                    Id = 29,
                    Temperature = 50,
                    State = "HOT",
                    Date = DateTime.Now,
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
