using TemperatureSensor.Entities;
using TemperatureSensor.Models;

namespace TemperatureSensor.Repository.Interface
{
    public interface IStateLimitRepository
    {
        Task<IEnumerable<StateLimit?>> GetAllStateLimitsAsync();
        Task UpdateStateLimit(StateLimit stateLimit);
    }
}
