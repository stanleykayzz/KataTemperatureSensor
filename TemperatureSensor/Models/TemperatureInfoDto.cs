﻿using System.ComponentModel.DataAnnotations;

namespace TemperatureSensor.Models
{
    public class TemperatureInfoDto
    {
        [Required]
        public int Id { get; set; }
        public int Temperature { get; set; }
        public string State { get; set; }
        public DateTime Date { get; set; }

        public TemperatureInfoDto()
        {
        }

        public TemperatureInfoDto(int temperature)
        {
            if (temperature < 19) State = "COLD";
            else if (temperature >= 19 && temperature < 30) State = "WARM";
            else if (temperature >= 30) State = "HOT";
            Date = DateTime.Now;
            Temperature = temperature;
        }
        public TemperatureInfoDto(int temperature, string etat, DateTime date)
        {
            Temperature = temperature;
            State = etat;
            Date = date;
        }

        public TemperatureInfoDto(int id, int temperature)
        {
            Id = id;
            if (temperature < 19) State = "COLD";
            else if (temperature >= 19 && temperature < 30) State = "WARM";
            else if (temperature >= 30) State = "HOT";
            Date = DateTime.Now;
            Temperature = temperature;
        }
    }
}
