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

        //public ICollection<StateLimit> states { get; set; }
        //= new List<StateLimit>();

        //public TemperatureInfo() { }

        //public TemperatureInfo(int temperature)
        //{
        //    if (temperature < 19) State = "COLD";
        //    else if (temperature >= 19 && temperature < 30) State = "WARM";
        //    else if (temperature >= 30) State = "HOT";
        //    Date = DateTime.Now;
        //    Temperature = temperature;
        //}

        //public TemperatureInfo(int id, int temperature)
        //{
        //    Id = id;
        //    if (temperature < 19) State = "COLD";
        //    else if (temperature >= 19 && temperature < 30) State = "WARM";
        //    else if (temperature >= 30) State = "HOT";
        //    Date = DateTime.Now;
        //    Temperature = temperature;
        //}
    }
}
