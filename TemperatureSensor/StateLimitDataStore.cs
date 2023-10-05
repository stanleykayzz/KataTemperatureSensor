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
                    Id = 1,
                    Name = "COLD",
                    Value = 19,
                },
                new StateLimitDto()
                {
                    Id = 2,
                    Name = "HOT",
                    Value = 30,
                },
                new StateLimitDto()
                {
                    Id = 3,
                    Name = "WARM",
                    Value = 30,
                }
            };
        }

    }
}
