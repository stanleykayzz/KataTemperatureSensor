namespace TemperatureSensor.Models
{
    public class TempereatureInfo
    {
        public int Temperature { get; set; }
        public string? State { get; set; }
        public DateTime? Date { get; set; }

        public TempereatureInfo(int temperature)
        {
            if (temperature < 19) State = "COLD";
            else if (temperature >= 19 && temperature < 30) State = "WARM";
            else if (temperature >= 30) State = "HOT";
            Date = DateTime.Now;
            Temperature = temperature;
        }
        public TempereatureInfo(int temperature, string etat, DateTime date)
        {
            Temperature = temperature;
            State = etat;
            Date = date;
        }
    }
}
