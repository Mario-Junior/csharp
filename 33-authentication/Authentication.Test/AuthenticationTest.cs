using Auth.Models;
using Auth.Controllers;
using Microsoft.AspNetCore.Mvc;

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
}
