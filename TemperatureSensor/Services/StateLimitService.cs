using TemperatureSensor.Models;
using TemperatureSensor.Repository.Interface;
using TemperatureSensor.Services.Interface;

namespace TemperatureSensor.Services
{
    public class StateLimitService : IStateLimitService
    {
        IStateLimitRepository _stateLimitRepository;

        public StateLimitService(IStateLimitRepository stateLimitRepository)
        {
            _stateLimitRepository = stateLimitRepository;
        }
        public async Task<IEnumerable<StateLimitDto>> GetAllStateLimitAsync()
        {
            var resultList = new List<StateLimitDto>();
            var allStateLimits = await _stateLimitRepository.GetAllStateLimitsAsync();
            foreach (var dto in allStateLimits)
            {
                var newStateLimit = new StateLimitDto();
                newStateLimit.Name = dto.Name;
                newStateLimit.Value = dto.Value;
                resultList.Add(newStateLimit);
            }
            return resultList;
        }
        public async Task UpdateStateLimit(StateLimitDto stateLimit)
        {
            var allStateLimits = await _stateLimitRepository.GetAllStateLimitsAsync();
            var stateLimitToUpdate = allStateLimits.FirstOrDefault(sl => sl.Name == stateLimit.Name);
            stateLimitToUpdate.Value = stateLimit.Value;
            _stateLimitRepository.UpdateStateLimit(stateLimitToUpdate);
        }
    }
}
