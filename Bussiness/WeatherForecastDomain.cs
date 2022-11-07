namespace Bussiness;

public class WeatherForecastDomain :IWeatherForecastDomain
{
    private static readonly string[] Summaries = new[]
    {
        "Test1", "Tes2","test 3"
    };


    public string[] Get()
    {
        return Summaries;
    }
}