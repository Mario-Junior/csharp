namespace App.Test;

public class TestWeatherForecast : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestWeatherForecast(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Theory(DisplayName = "WeatherForecast deve responder com status 200 ~ 299 para rotas")]    
    [InlineData("/")]
    public async Task GetInitialEndpointReturnSuccess(string url)
    {        
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);

        response.EnsureSuccessStatusCode();
        response.Content.Headers.ContentType!.ToString().Should().Be("text/plain; charset=utf-8");
    }

    [Theory(DisplayName = "WeatherForecast deve responder com status 200 ~ 299 para rotas")]    
    [InlineData("/weatherforecast")]
    public async Task GetEndpointsReturnSuccess(string url)
    {        
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);

        response.EnsureSuccessStatusCode();
        response.Content.Headers.ContentType!.ToString().Should().Be("application/json; charset=utf-8");
    }
}
