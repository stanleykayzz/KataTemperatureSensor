using TemperatureSensor.Entities;
using TemperatureSensor.Models;

namespace TemperatureSensor.Repository.Interface
{
    public interface ITemperatureInfoRepository
    {
        Task<TemperatureInfo> GetTemperatureInfoByIdAsync(int id);
        Task<IEnumerable<TemperatureInfo>> GetAllTemperatureInfoAsync();
        Task CreateTemperatureInfoAsync(TemperatureInfo temperatureInfo);
        Task UpdateTemperatureInfoAsync(TemperatureInfo temperatureInfo);
        Task DeleteTemperatureInfoAsync(int id);


        //Task<IEnumerable<TemperatureInfo>> GetAllAsync();
        //Task<IEnumerable<StateLimit>> GetAllStateLimitsAsync();
        //Task<TemperatureInfo?> GetTemperatureInfoAsync(int id);
        //Task<StateLimit?> GetStateLimitByNameAsync(string state);
        //Task UpdateStateLimits(int hot, int cold, int warm);
        //Task<TemperatureInfo?> AddTemperatureInfo(int temperature);
        //Task<bool> SaveChangesAsync();
    }
}
