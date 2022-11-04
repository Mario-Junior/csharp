using Auth.Models;
using Auth.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;

namespace Authentication.Test;

public class UnitTest1
{
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
}
