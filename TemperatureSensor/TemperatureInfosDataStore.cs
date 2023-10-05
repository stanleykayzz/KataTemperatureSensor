using TemperatureSensor.Models;

namespace TemperatureSensor
{
    public class TemperatureInfosDataStore
    {
        public List<TemperatureInfoDto> TemperatureInfos;

        public static TemperatureInfosDataStore Current { get; } = new TemperatureInfosDataStore();

        public TemperatureInfosDataStore()
        {
            TemperatureInfos = new List<TemperatureInfoDto>()
            {
                new TemperatureInfoDto()
                {
                    Id = 1,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 2,
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 3,
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 4,
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 5,
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 6,
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 7,
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 8,
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 9,
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },

                new TemperatureInfoDto()
                {
                    Id = 10,
                    Temperature = 8,
                    State = "COLD",
                    Date = DateTime.Now,
                },

                new TemperatureInfoDto()
                {
                    Id = 11,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 12,
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 13,
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 14,
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 15,
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },

                new TemperatureInfoDto()
                {
                    Id = 16,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 17,
                    Temperature = 2,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 18,
                    Temperature = 6,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 19,
                    Temperature = 40,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 20,
                    Temperature = 25,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 21,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 22,
                    Temperature = 47,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 23,
                    Temperature = 38,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 24,
                    Temperature = 14,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 25,
                    Temperature = 15,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 26,
                    Temperature = 36,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 27,
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Id = 28,
                    Temperature = 27,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
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
