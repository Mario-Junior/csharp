using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Net;
using System.Text.Json;
using System.Net.Http.Json;

namespace TypedClient.Test;

public class TestingWebAppFactory<TEntryPoint> : WebApplicationFactory<Program> where TEntryPoint : Program
{
  protected override void ConfigureWebHost(IWebHostBuilder builder)
  {
    builder.UseEnvironment("Testing");

    base.ConfigureWebHost(builder);
  }

  protected override IHost CreateHost(IHostBuilder builder)
  {
    return base.CreateHost(builder);
  }
}

public class TypedClientTestServer : IClassFixture<TestingWebAppFactory<Program>>
{
  private readonly HttpClient? _client;

  public TypedClientTestServer(TestingWebAppFactory<Program> factory)
    => _client = factory.CreateClient();

  [Fact]
  public async void ShouldMakeARequestWithTestServer()
  {
    var response = await _client!.GetAsync("/TypedClient/01001000")!;
    var result = await response.Content.ReadFromJsonAsync<object>();
    
    response.StatusCode.Should().Be(HttpStatusCode.OK);
    result.Should().BeOfType<JsonElement>();
  }
}
