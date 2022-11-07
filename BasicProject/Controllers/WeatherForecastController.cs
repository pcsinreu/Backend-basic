using Bussiness;
using Microsoft.AspNetCore.Mvc;

namespace BasicProject.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
   private readonly IWeatherForecastDomain _weatherForecastDomain = new WeatherForecastDomain();

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = _weatherForecastDomain.Get()[Random.Shared.Next(_weatherForecastDomain.Get().Length)]
            })
            .ToArray();
    }
}