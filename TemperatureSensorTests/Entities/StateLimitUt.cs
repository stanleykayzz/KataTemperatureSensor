using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureSensor.Entities;

namespace TemperatureSensorTests.Entities
{
    [TestFixture]
    public class StateLimitUt
    {
        [Test]
        [TestCase("Hot", 33)]
        [TestCase("Cold", 16)]
        [TestCase("Warm", 20)]
        public void StateLimit_PropertiesOk_WithValues(string name, int limit)
        {
            var stateLimit = new StateLimit(name,limit);

            // Act & Assert
            Assert.AreEqual(name, stateLimit.Name);
            Assert.AreEqual(limit, stateLimit.Value);
        }
    }
}
