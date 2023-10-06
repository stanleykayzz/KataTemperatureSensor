using Microsoft.AspNetCore.Mvc;
using TemperatureSensor.Entities;
using TemperatureSensor.Models;
using TemperatureSensor.Services;

namespace TemperatureSensor.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TemperaturesController : ControllerBase
    {
        private readonly ITemperatureInfoRepository temperatureInfoRepository;

        public TemperaturesController(ITemperatureInfoRepository temperatureInfoRepository)
        {
            this.temperatureInfoRepository = temperatureInfoRepository ??
                throw new ArgumentNullException(nameof(temperatureInfoRepository));
        }
        [HttpGet("temperatures")]
        public async Task<ActionResult<TemperatureInfoDto>> GetTemperatures()
        {
            var temperatureInfos = await temperatureInfoRepository.GetAllAsync();

            return Ok(temperatureInfos);
            //return Ok(TemperatureInfosDataStore.Current.TemperatureInfos);
        }

        [HttpGet("temperatures/last/{number}")]
        public async Task<ActionResult<TemperatureInfoDto>> GetLastTemperaturesByNumber(int number)
        {
            //var count = TemperatureInfosDataStore.Current.TemperatureInfos.Count();
            var temperatureInfos = await temperatureInfoRepository.GetAllAsync();
            var count = temperatureInfos.Count();

            //var LastXTemperatures = TemperatureInfosDataStore.Current.TemperatureInfos.Skip(Math.Max(0, count - number));
            var LastXTemperatures = temperatureInfos.Skip(Math.Max(0, count - number));

            if(count < number)
            {
                return NotFound();
            }
            return Ok(LastXTemperatures);
        }

        [HttpGet("temperature/{id}")]
        public ActionResult<TemperatureInfoDto> GetTemperature(int id)
        {
            //var temperatureInfo = TemperatureInfosDataStore.Current.TemperatureInfos.FirstOrDefault(x => x.Id == id);
            var temperatureInfo = temperatureInfoRepository.GetTemperatureInfoAsync(id);
            
            if (temperatureInfo == null) { return NotFound(); }

            return Ok(temperatureInfo);
        }
            
        [HttpPost("captor/{temperature}")]
        public async Task<ActionResult<TemperatureInfo>> PostTemperature(int temperature)
        {
            var temp = await temperatureInfoRepository.AddTemperatureInfo(temperature);
            //return CreatedAtRoute("/api/captor/" + temperature, temp);
            return Ok(temp);
        }

        [HttpGet("temperature/limits")]
        public async Task<ActionResult<StateLimit>> GetTemperatureLimits()
        {
            //return Ok(StateLimitDataStore.CurrentLimits.StateLimits);
            return Ok(await temperatureInfoRepository.GetAllStateLimitsAsync());
        }

        [HttpPost]
        [Route("temperature/limit")]
        public async Task<ActionResult> SetTemperatureStateLimit(
            [FromQuery] int hot,
            [FromQuery] int cold,
            [FromQuery] int warm
            )
        {
            //var StateLimits = StateLimitDataStore.CurrentLimits.StateLimits;
            //if (hot != null)
            //{
            //    var hotItem = StateLimits.FirstOrDefault(x => x.Name == "HOT");
            //    hotItem.Value = hot;
            //}
            //if (cold != null)
            //{
            //    var coldItem = StateLimits.FirstOrDefault(x => x.Name == "COLD");
            //    coldItem.Value = cold;
            //}
            //if (warm != null)
            //{
            //    var warmItem = StateLimits.FirstOrDefault(x => x.Name == "WARM");
            //    warmItem.Value = warm;
            //}

            await temperatureInfoRepository.UpdateStateLimits(hot, cold, warm);
            
            return Ok("Updated Temperature state limit");
        }
    }
}
