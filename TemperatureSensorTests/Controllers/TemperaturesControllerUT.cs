using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensorTests.Controllers
{
    [TestFixture]
    public class TemperaturesControllerUT
    {
        private HttpClient _httpClient;
        private WebApplicationFactory<Program> _webApplicationFactory;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _webApplicationFactory = new WebApplicationFactory<Program>();
            _httpClient = _webApplicationFactory.CreateClient();
        }
        [OneTimeTearDown]
        public void OnTimeTearDow()
        {
            _httpClient.Dispose();
            _webApplicationFactory?.Dispose();
        }

        [Test]
        public async Task GetStateLimits_ReturnOKResult()
        {

            // Arrange - No need to arrange anything for this test

            // Act
            var response = await _httpClient.GetAsync("/api/temperatures");

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.AreEqual("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }
    }
}
