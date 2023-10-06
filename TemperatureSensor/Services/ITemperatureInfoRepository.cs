using TemperatureSensor.Entities;

namespace TemperatureSensor.Services
{
    public interface ITemperatureInfoRepository
    {
        Task<IEnumerable<TemperatureInfo>> GetAllAsync();
        Task<IEnumerable<StateLimit>> GetAllStateLimitsAsync();
        Task<TemperatureInfo?> GetTemperatureInfoAsync(int id);
        Task<StateLimit?> GetStateLimitByNameAsync(string state);
        Task UpdateStateLimits(int hot,int cold,int warm);
        Task<TemperatureInfo?> AddTemperatureInfo(int temperature);
        Task<bool> SaveChangesAsync();
    }
}
