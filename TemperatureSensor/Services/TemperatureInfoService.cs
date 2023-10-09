using TemperatureSensor.Entities;
using TemperatureSensor.Models;
using TemperatureSensor.Repository;
using TemperatureSensor.Repository.Interface;

namespace TemperatureSensor.Services
{
    public class TemperatureInfoService : ITemperatureInfoService
    {
        private ITemperatureInfoRepository _repository;

        public TemperatureInfoService(ITemperatureInfoRepository temperatureInfoRepository)
        {
            _repository = temperatureInfoRepository;
        }

        public async Task CreateTemperatureInfoAsync(TemperatureInfoDto temperatureInfoDto)
        {
            await _repository.CreateTemperatureInfoAsync(temperatureInfoDto.convertToTemperatureInfo());
        }

        public async Task DeleteTemperatureInfoAsync(int id)
        {
            await _repository.DeleteTemperatureInfoAsync(id);
        }

        public async Task<IEnumerable<TemperatureInfoDto>> GetAllTemperatureInfoAsync()
        {
            var listInfos = await _repository.GetAllTemperatureInfoAsync();
            var listDto = new List<TemperatureInfoDto>();
            foreach (var info in listInfos)
            {
                var dto = new TemperatureInfoDto();
                dto.Temperature = info.Temperature;
                dto.State = info.State;
                dto.Date = info.Date;
                listDto.Add(dto);
            }
            return listDto;
        }

        public async Task<IEnumerable<TemperatureInfoDto>> GetLastTemperatureInfoByNumerAsync(int number)
        {
            var temperatureInfos = await _repository.GetAllTemperatureInfoAsync();

            var count = temperatureInfos.Count();
            var returnList = new List<TemperatureInfoDto>();

            var list = temperatureInfos.Skip(Math.Max(0, count - number));
            foreach (var info in list)
            {
                returnList.Add(info.convertToDto());
            }

            return returnList;
        }

        public async Task<TemperatureInfoDto> GetTemperatureInfoByIdAsync(int id)
        {
            var dto = new TemperatureInfoDto();
            var selectedDto = await _repository.GetTemperatureInfoByIdAsync(id);
            dto = selectedDto.convertToDto();
            return dto;
        }

        public Task UpdateStateLimitAsync(TemperatureInfoDto temperatureInfoDto)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateTemperatureInfoAsync(int id, TemperatureInfoDto temperatureInfoDto)
        {
            var existingDto = await _repository.GetTemperatureInfoByIdAsync(id);
            if (existingDto != null)
            {
                existingDto.Temperature = temperatureInfoDto.Temperature;
                existingDto.State = temperatureInfoDto.State;
                existingDto.Date = temperatureInfoDto.Date;
                await _repository.UpdateTemperatureInfoAsync(existingDto);
            }
        }
    }
}
