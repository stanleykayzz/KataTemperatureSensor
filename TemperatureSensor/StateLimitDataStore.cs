using TemperatureSensor.Models;

namespace TemperatureSensor
{
    public class StateLimitDataStore
    {
        public List<StateLimitDto> StateLimits;

        public static StateLimitDataStore CurrentLimits { get; } = new StateLimitDataStore();

        public StateLimitDataStore()
        {
            StateLimits = new List<StateLimitDto>()
            {
                new StateLimitDto()
                {
                    Name = "COLD",
                    Value = 19,
                },
                new StateLimitDto()
                {
                    Name = "HOT",
                    Value = 30,
                },
                new StateLimitDto()
                {
                    Name = "WARM",
                    Value = 30,
                }
            };
        }

    }
}
