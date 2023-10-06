using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
