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
        public ActionResult<TemperatureInfosDto> GetTemperatures()
        {
            return Ok(TemperatureInfosDataStore.Current.TemperatureInfos);
        }

        [HttpGet("temperatures/last/{number}")]
        public ActionResult<TemperatureInfosDto> GetLastTemperaturesByNumber(int number)
        {
            var count = TemperatureInfosDataStore.Current.TemperatureInfos.Count();
            var lastXList = TemperatureInfosDataStore.Current.TemperatureInfos.Skip(Math.Max(0, count - number));

            if(count < number)
            {
                return NotFound();
            }
            return Ok(lastXList);
        }

        [HttpGet("temperature/{id}")]
        public ActionResult<TemperatureInfosDto> GetTemperature(int id)
        {
            var temperatureInfo = TemperatureInfosDataStore.Current.TemperatureInfos.FirstOrDefault(x => x.Id == id);
            
            if (temperatureInfo == null) { return NotFound(); }

            return Ok(temperatureInfo);
        }
            
        [HttpPost("captor/{temperature}")]
        public ActionResult PostTemperature(int temperature)
        {
            var countTemperatures = TemperatureInfosDataStore.Current.TemperatureInfos.Count();
            var Temperature = new TempereatureInfo(temperature);
            var PostedTemperature = new TemperatureInfosDto(countTemperatures + 1, Temperature);
            TemperatureInfosDataStore.Current.TemperatureInfos.Add(
                PostedTemperature
            );
            return Ok(PostedTemperature);
        }
    }
}
