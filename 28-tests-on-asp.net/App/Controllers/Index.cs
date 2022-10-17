using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("/")]
public class IndexController : ControllerBase
{
    private readonly ILogger<IndexController>? _logger;

    public IndexController(ILogger<IndexController> logger)
    {
        _logger = logger;
    }

    [HttpGet("/", Name = "GetIndex")]
    public string Get()
    {
        return "Bem-vindo ao Weather Forecast\nUse /weatherforecast para obter a previsão dos próximos dias.";
    }
}
