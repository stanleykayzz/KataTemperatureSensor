using TemperatureSensor.Entities;
using TemperatureSensor.Models;

namespace TemperatureSensor.Services
{
    public interface ITemperatureInfoService
    {
        Task<IEnumerable<TemperatureInfoDto>> GetAllTemperatureInfoAsync();
        Task<IEnumerable<TemperatureInfoDto>> GetLastTemperatureInfoByNumerAsync(int number);
        Task<TemperatureInfoDto> GetTemperatureInfoByIdAsync(int id);
        Task CreateTemperatureInfoAsync(TemperatureInfoDto temperatureInfoDto);
        Task UpdateTemperatureInfoAsync(int id,TemperatureInfoDto temperatureInfoDto);
        Task UpdateStateLimitAsync(TemperatureInfoDto temperatureInfoDto);
        Task DeleteTemperatureInfoAsync(int id);
    }
}
