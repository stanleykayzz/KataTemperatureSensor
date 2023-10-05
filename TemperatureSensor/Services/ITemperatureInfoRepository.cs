using TemperatureSensor.Entities;

namespace TemperatureSensor.Services
{
    public interface ITemperatureInfoRepository
    {
        Task<IEnumerable<TemperatureInfo>> GetAllAsync();
        Task<TemperatureInfo?> GetTemperatureInfoAsync();
    }
}
