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
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },

                new TemperatureInfoDto()
                {
                    Temperature = 8,
                    State = "COLD",
                    Date = DateTime.Now,
                },

                new TemperatureInfoDto()
                {
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 24,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 30,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 26,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 34,
                    State = "HOT",
                    Date = DateTime.Now,
                },

                new TemperatureInfoDto()
                {
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 2,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 6,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 40,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 25,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 47,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 38,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 14,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 15,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 36,
                    State = "HOT",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 18,
                    State = "COLD",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 27,
                    State = "WARM",
                    Date = DateTime.Now,
                },
                new TemperatureInfoDto()
                {
                    Temperature = 50,
                    State = "HOT",
                    Date = DateTime.Now,
                },
            };
        }

    }
}
