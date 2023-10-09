using Microsoft.AspNetCore.Mvc;
using TemperatureSensor.Entities;
using TemperatureSensor.Models;
using TemperatureSensor.Repository;
using TemperatureSensor.Repository.Interface;
using TemperatureSensor.Services;
using TemperatureSensor.Services.Interface;

namespace TemperatureSensor.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TemperaturesController : ControllerBase
    {
        private readonly ITemperatureInfoService _temperatureInfoService;
        private readonly IStateLimitService _stateLimitService;

        public TemperaturesController(ITemperatureInfoService service, IStateLimitService stateLimitService)
        {
            this._temperatureInfoService = service ??
                throw new ArgumentNullException(nameof(_temperatureInfoService));

            this._stateLimitService = stateLimitService ??
                throw new ArgumentNullException(nameof(_stateLimitService));
        }
        [HttpGet("temperatures")]
        public async Task<ActionResult<TemperatureInfoDto>> GetTemperatures()
        {
            var temperatureInfos = await _temperatureInfoService.GetAllTemperatureInfoAsync();

            return Ok(temperatureInfos);
            //return Ok(TemperatureInfosDataStore.Current.TemperatureInfos);
        }

        [HttpGet("temperatures/last/{number}")]
        public async Task<ActionResult<TemperatureInfoDto>> GetLastTemperaturesByNumber(int number)
        {
            //var count = TemperatureInfosDataStore.Current.TemperatureInfos.Count();
            var list = await _temperatureInfoService.GetLastTemperatureInfoByNumerAsync(number);

            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);
        }

        [HttpGet("temperature/{id}")]
        public ActionResult<TemperatureInfoDto?> GetTemperature(int id)
        {
            //var temperatureInfo = TemperatureInfosDataStore.Current.TemperatureInfos.FirstOrDefault(x => x.Id == id);
            var temperatureInfo = _temperatureInfoService.GetTemperatureInfoByIdAsync(id).Result;

            if (temperatureInfo == null) { return NotFound(); }

            return Ok(temperatureInfo);
        }

        [HttpPost("captor/{temperature}")]
        public async Task<ActionResult<TemperatureInfoDto>> PostTemperature(int temperature)
        {
            var newTemperature = new TemperatureInfoDto(temperature);
            await _temperatureInfoService.CreateTemperatureInfoAsync(newTemperature);
            //return CreatedAtRoute("/api/captor/" + temperature, temp);
            return Ok(newTemperature);
        }

        [HttpGet("temperature/limits")]
        public async Task<ActionResult<StateLimit>> GetTemperatureLimits()
        {
            //return Ok(StateLimitDataStore.CurrentLimits.StateLimits);
            return Ok(await _stateLimitService.GetAllStateLimitAsync());
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
            if (hot != null)
            {
                //var hotItem = StateLimits.FirstOrDefault(x => x.Name == "HOT");
                var dto = new StateLimitDto("HOT", hot);
                var hotItem = _stateLimitService.UpdateStateLimit(dto);

            }
            if (cold != null)
            {
                var dto = new StateLimitDto("COLD", cold);
                var hotItem = _stateLimitService.UpdateStateLimit(dto);
            }
            if (warm != null)
            {
                var dto = new StateLimitDto("WARM", warm);
                var hotItem = _stateLimitService.UpdateStateLimit(dto);
            }

            return Ok("Updated Temperature state limit");
        }
    }
}
