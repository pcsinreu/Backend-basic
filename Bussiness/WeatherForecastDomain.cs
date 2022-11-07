namespace Bussiness;

public class WeatherForecastDomain :IWeatherForecastDomain
{
    private static readonly string[] Summaries = new[]
    {
        "Test1", "Tes2", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


    public string[] Get()
    {
        return Summaries;
    }
}