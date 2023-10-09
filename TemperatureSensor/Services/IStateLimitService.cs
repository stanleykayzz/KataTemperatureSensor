using System.Collections.Generic;
using TemperatureSensor.Models;

namespace TemperatureSensor.Services.Interface
{
    public interface IStateLimitService
    {
        Task<IEnumerable<StateLimitDto>> GetAllStateLimitAsync();
        Task UpdateStateLimit(StateLimitDto stateLimit);
    }
}
