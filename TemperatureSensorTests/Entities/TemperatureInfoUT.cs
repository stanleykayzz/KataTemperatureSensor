using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureSensor.Entities;

namespace TemperatureSensorTests.Entities
{
    [TestFixture]
    public class TemperatureInfoUT
    {
        [Test]
        [TestCase(16)]
        [TestCase(22)]
        public void Test_TemperatureInfoOKWitParams(int temperature)
        {
            var temperatureInfo = new TemperatureInfo(temperature);

            Assert.IsNotNull(temperatureInfo);
            Assert.IsNotNull(temperatureInfo.State);
            Assert.AreEqual(temperatureInfo.Temperature, temperature);
        }
    }
}
