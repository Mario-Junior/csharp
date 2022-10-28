using Microsoft.AspNetCore.Mvc;

namespace MigrationsStudy.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProduct")]
    public IEnumerable<Product> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Product
        {
            Name = "Teste",
            Description = "Descrição",
            Price = 10.50M,
            Quantity = 100
        })
        .ToArray();
    }
}
