namespace TemperatureSensor.Models
{
    public class TemperatureInfosDto
    {
        public int Id { get; set; }
        public int Temperature { get; set; }
        public string State { get; set; }
        public DateTime Date { get; set; }

        public TemperatureInfosDto()
        {
            
        }

        public TemperatureInfosDto(int id, TempereatureInfo tempereatureInfo)
        {
            Id = id;
            Temperature = tempereatureInfo.Temperature;
            State = tempereatureInfo.State;
            Date = (DateTime)tempereatureInfo.Date;
        }

    }
}
