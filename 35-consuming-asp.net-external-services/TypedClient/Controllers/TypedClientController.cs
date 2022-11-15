using Microsoft.AspNetCore.Mvc;
using TypedClient.Services;

namespace TypedClient.Controllers;

[ApiController]
[Route("[controller]")]
public class TypedClientController : ControllerBase
{
  private ICepService? _cepService;
  public TypedClientController(ICepService cepService)
  {
    _cepService = cepService;
  }

  [HttpGet]
  [Route("{cep}")]
  public async Task<IActionResult> GetCep(string cep)
  {
    var address = await _cepService!.GetCep(cep)!;
    if (address == null)
    {
      return NotFound();
    }

    return Ok(address);
  }
}
