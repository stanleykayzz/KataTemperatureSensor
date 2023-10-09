using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TemperatureSensor.Models;

namespace TemperatureSensor.Entities
{
    public class TemperatureInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Temperature { get; set; }
        
        [Required]
        public string State { get; set; }
        public DateTime Date { get; set; }

        public TemperatureInfo() { }

        public TemperatureInfo convertDto(TemperatureInfoDto dto)
        {
            var res = new TemperatureInfo();
            res.Date = dto.Date;
            res.Temperature = dto.Temperature;
            res.State = dto.State;
            return res;
        }
        public TemperatureInfoDto convertToDto()
        {
            var res = new TemperatureInfoDto();
            res.Date = Date;
            res.Temperature = Temperature;
            res.State = State;
            return res;
        }

        public TemperatureInfo(int temperature, int cold = 19, int warm = 30, int hot = 30)
        {
            if (temperature < cold) State = "COLD";
            else if (temperature >= cold && temperature < warm) State = "WARM";
            else if (temperature >= hot) State = "HOT";
            Date = DateTime.Now;
            Temperature = temperature;
        }
    }
}
