// add a namespace for WeatherForecaseController
using WebApi.Controllers;
namespace WebApiTests;

[TestClass]
public class WeatherForecaseControllerTests
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    // add a test method that tests the GetRange action method of WatherForecaseController
    [TestMethod]
    public void TestMethod2()
    {
        // arrange
        var controller = new WeatherForecastController(null);

        // act
        var result = controller.GetRange(new DateRange { Length = 5 });

        // assert
        Assert.AreEqual(5, result.Count());
    }
}