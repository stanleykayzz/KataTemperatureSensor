using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using TemperatureSensor.Models;

namespace TemperatureSensor.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TemperaturesController : ControllerBase
    {
        [HttpGet("temperatures")]
        public ActionResult<TemperatureInfoDto> GetTemperatures()
        {
            return Ok(TemperatureInfosDataStore.Current.TemperatureInfos);
        }

        [HttpGet("temperatures/last/{number}")]
        public ActionResult<TemperatureInfoDto> GetLastTemperaturesByNumber(int number)
        {
            var count = TemperatureInfosDataStore.Current.TemperatureInfos.Count();
            var LastXTemperatures = TemperatureInfosDataStore.Current.TemperatureInfos.Skip(Math.Max(0, count - number));

            if(count < number)
            {
                return NotFound();
            }
            return Ok(LastXTemperatures);
        }

        [HttpGet("temperature/{id}")]
        public ActionResult<TemperatureInfoDto> GetTemperature(int id)
        {
            var temperatureInfo = TemperatureInfosDataStore.Current.TemperatureInfos.FirstOrDefault(x => x.Id == id);
            
            if (temperatureInfo == null) { return NotFound(); }

            return Ok(temperatureInfo);
        }
            
        [HttpPost("captor/{temperature}")]
        public ActionResult PostTemperature(int temperature)
        {
            var countTemperatures = TemperatureInfosDataStore.Current.TemperatureInfos.Count();
            var PostedTemperature = new TemperatureInfoDto(countTemperatures + 1, temperature);
            TemperatureInfosDataStore.Current.TemperatureInfos.Add(
                PostedTemperature
            );
            return Ok(PostedTemperature);
        }

        [HttpGet("temperature/limits")]
        public ActionResult<StateLimitDto> GetTemperatureLimits()
        {
            return Ok(StateLimitDataStore.CurrentLimits.StateLimits);
        }

        [HttpPost]
        [Route("temperature/limit")]
        public ActionResult SetTemperatureStateLimit(
            [FromQuery] int hot,
            [FromQuery] int cold,
            [FromQuery] int warm
            )
        {
            var StateLimits = StateLimitDataStore.CurrentLimits.StateLimits;
            if (hot != null)
            {
                var hotItem = StateLimits.FirstOrDefault(x => x.Name == "HOT");
                hotItem.Value = hot;
            }
            if (cold != null)
            {
                var coldItem = StateLimits.FirstOrDefault(x => x.Name == "COLD");
                coldItem.Value = cold;
            }
            if (warm != null)
            {
                var warmItem = StateLimits.FirstOrDefault(x => x.Name == "WARM");
                warmItem.Value = warm;
            }
            return Ok("Updated Temperature state limit");
        }
    }
}
