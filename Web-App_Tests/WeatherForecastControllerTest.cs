using System;
using Web_App.Controllers;
using Xunit;
using NSubstitute;
using Microsoft.Extensions.Logging;

namespace Web_App_Tests
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void Get_Success()
        {
            var mockLogger = Substitute.For<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(mockLogger);

            var response = controller.Get();
            Assert.NotNull(response);
        }
    }
}
