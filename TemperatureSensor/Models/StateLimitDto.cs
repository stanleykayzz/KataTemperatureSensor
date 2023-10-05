namespace TemperatureSensor.Models
{
    public class StateLimitDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public StateLimitDto()
        {
            
        }
        public StateLimitDto(int id, string name, int value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
    }
}
