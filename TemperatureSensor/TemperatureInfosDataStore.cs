using TemperatureSensor.Models;

namespace TemperatureSensor
{
    public class TemperatureInfosDataStore
    {
        public List<TemperatureInfosDto> TemperatureInfos;

        public static TemperatureInfosDataStore Current { get; } = new TemperatureInfosDataStore();

        public TemperatureInfosDataStore()
        {
            TemperatureInfos = new List<TemperatureInfosDto>()
            {
                new TemperatureInfosDto()
                {
                    Id = 1,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 2,
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 3,
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 4,
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 5,
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 6,
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 7,
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 8,
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 9,
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },

                new TemperatureInfosDto()
                {
                    Id = 10,
                    Temperature = 8,
                    State = "COLD",
                    Date = DateTime.Now,
                },

                new TemperatureInfosDto()
                {
                    Id = 11,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 12,
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 13,
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 14,
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 15,
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },

                new TemperatureInfosDto()
                {
                    Id = 16,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 17,
                    Temperature = 2,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 18,
                    Temperature = 6,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 19,
                    Temperature = 40,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 20,
                    Temperature = 25,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 21,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 22,
                    Temperature = 47,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 23,
                    Temperature = 38,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 24,
                    Temperature = 14,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 25,
                    Temperature = 15,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 26,
                    Temperature = 36,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 27,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 28,
                    Temperature = 27,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfosDto()
                {
                    Id = 29,
                    Temperature = 50,
                    State = "HOT",
                    Date = DateTime.Now,
                },
            };
        }
    }
}
