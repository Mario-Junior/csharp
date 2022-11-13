using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Filters;

public class ValidationFilterAttribute : ActionFilterAttribute
{
  public override void OnActionExecuting(ActionExecutingContext context)
  {
    // O filtro verifica se o Model presente na requisição é válido
    // ou seja: Todos os campos obrigatórios existem por exemplo
    if(!context.ModelState.IsValid)
    {
      // Caso o Model não seja válido, o filtro interrompe a requisição, respondendo com
      // um erro para a pessoa cliente
      context.Result = new UnprocessableEntityObjectResult(context.ModelState);
    }
  }
}
