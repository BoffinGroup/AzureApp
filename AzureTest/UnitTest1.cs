using System;
using Xunit;
using AzureAPI.Controllers;

using AzureAPI;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace AzureTest
{
    
    public class UnitTest1
    {
       // private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherForecastController _controller;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

       
       public UnitTest1() {
           // _logger = logger;
            _controller = new WeatherForecastController();
        }
       
        [Fact]
        public void When_Called_ReturnList()
        {
           
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(okResult);
            //Assert.Equal(2, items.Count);
        }

    }
}
