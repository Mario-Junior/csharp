using Auth.Models;
using Auth.Controllers;
using Auth.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using System.Web;
using System.Text;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Authentication.Test;

public class UnitTest1 : IClassFixture<WebApplication<Program>>
{
    private readonly HttpClient _client;

    public UnitTest1(WebApplication<Program> factory)
    {
        _client = factory.CreateClient();
    }

    private async Task<HttpResponseMessage> AuthenticateRequest(User user)
    {
        var json = JsonConvert.SerializeObject(user);
        var body = new StringContent(json, Encoding.UTF8, "application/json");                
        return await _client.PostAsync("/api", body);
    }

    private async Task<HttpResponseMessage> PrivateRequest(string token) 
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        return await _client.GetAsync("/api/private");
    }

    [Theory]
    [InlineData("Testador1", "123,456")]
    [InlineData("Testador2", "123,456")]
    public void TestAuthenticateSuccess(string name, string password)
    {
        User user = new() 
        {
            Name = name,
            Password = password
        };

        var response = new AuthController().Authenticate(user);
        response.Value.Token.Should().NotBeNull();
    }

    [Theory]
    [InlineData("Luiz", "trybes2")]
    [InlineData("Mayara", "trybe1")]
    [InlineData("Rahel", "123456")]
    [InlineData("Marina", "software")]
    public void TestAuthenticateNotFoundFail(string name, string password)
    {
        User user = new() 
        {
        Name = name,
        Password = password
        };

        var response = new AuthController().Authenticate(user);
        response.Result.Should().BeOfType<NotFoundObjectResult>();
    }

    [Theory]
    [InlineData("Maria", "")]
    [InlineData("", "trybe1")]
    [InlineData("", "")]
    public void TestAuthenticateBadRequestFail(string name, string password)
    {
        User user = null;

        var response = new AuthController().Authenticate(user);
        response.Result.Should().BeOfType<BadRequestObjectResult>();
    }

    [Theory]
    [InlineData("Testador1", "123,456")]
    [InlineData("Testador2", "123,456")]
    public async void TestPrivateEndpointSuccess(string name, string password) 
    {
        const string resultExpected = "Se voc?? est?? vendo essa frase, voc?? possui autoriza????o";

        var user = new User 
        {
            Name = name,
            Password = password
        }; 

        var responseAuthenticate = await AuthenticateRequest(user);
        var authString = await responseAuthenticate.Content.ReadAsStringAsync();
        var userViewModel = JsonConvert.DeserializeObject<UserViewModel>(authString);
        var responsePrivate = await PrivateRequest(userViewModel.Token);
        var responsePrivateString = await responsePrivate.Content.ReadAsStringAsync();
        responsePrivateString.Should().Be(resultExpected);
    }
}
