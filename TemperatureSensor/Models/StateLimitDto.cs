namespace TemperatureSensor.Models
{
    public class StateLimitDto
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public StateLimitDto()
        {            
        }
        public StateLimitDto(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
