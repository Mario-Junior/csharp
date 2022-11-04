using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Auth.Models;
using Auth.Repositories;
using Auth.Services;
using Auth.ViewModels;

namespace Auth.Controllers;

[Route("/api")]
[ApiController]
public class AuthController : ControllerBase
{
    [HttpPost]

    public ActionResult<UserViewModel> Authenticate([FromBody] User user)
    {
    UserViewModel userViewModel = new();
    try
    {
        userViewModel.User = new UserRepository(
            new DatabaseContext()
        ).Get(user);

        if (userViewModel.User == null)
        {
        return NotFound("User not found!");
        }

        userViewModel.Token = new TokenGenerator().Generate();

        userViewModel.User.Password = string.Empty;
    } 
    catch (Exception ex)
    {
        return BadRequest(ex.Message);
    }
    return userViewModel;
    }

    [HttpGet]
    [Route("private")]
    [Authorize]
    public string Get()
    {
        return "Se você está vendo essa frase, você possui autorização";
    }
}
