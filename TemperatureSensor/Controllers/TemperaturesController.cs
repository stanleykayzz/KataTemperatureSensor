using Microsoft.AspNetCore.Mvc;

namespace TemperatureSensor.Controllers
{
    [ApiController]
    [Route("api/temperatures")]
    public class TemperaturesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetTemperatures()
        {
            return new JsonResult(TemperatureInfosDataStore.Current.TemperatureInfos);
        }
    }
}
