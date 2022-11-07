using Bussiness;

namespace BussinessDomain.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var test = new WeatherForecastDomain();

       var result= test.Get();
        
        Assert.Equal(3,result.Length);

    }
}