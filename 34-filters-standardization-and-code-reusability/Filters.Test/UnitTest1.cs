using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Routing;
using Moq;

namespace Filters.Test;

public class ValidationFilterAttribute_Tests
{
    [Fact]
    public void OnActionExecuting_ShouldRespondWithError()
    {
        // Arrange

        // Criar um ModelState para usar como contexto do filtro
        var modelState = new ModelStateDictionary();
        // Adicionar erros de validação ao ModelState
        modelState.AddModelError("somekey", "Some error message");

        // Criar o contexto do filtro com o ModelState com erros de validação
        var actionContext = new ActionContext(
            new DefaultHttpContext(),
            Mock.Of<RouteData>(),
            Mock.Of<ActionDescriptor>(),
            modelState
        );


        // Criamos um contexto para a função OnActionExecuting
        var resultExecutingContext = new ActionExecutingContext(
            actionContext,
            new List<IFilterMetadata>(),
            new Dictionary<string, object?>(),
            Mock.Of<Controller>()
        );

        // Act

        // Chamamos a função OnActionExecuting
        var actionFilter = new ValidationFilterAttribute();
        actionFilter.OnActionExecuting(resultExecutingContext);


        // Assert
        // Verificamos se a função adicionou um erro aos resultados da requisição
        resultExecutingContext.Result.Should().BeOfType<UnprocessableEntityObjectResult>();
    }
}
