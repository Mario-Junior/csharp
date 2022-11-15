using System.Text.Json;
using TypedClient.Services;

namespace TypedClient.Test;

public class TypedClientTest
{
    [Fact]
    public async void ShouldMakeARequest()
    {
        var mockClient = new Mock<HttpClient>();
        var cepService = new CepService(mockClient.Object);
        var result = await cepService.GetCep("01001000");

        result.Should().BeOfType<JsonElement>();
    }
}
