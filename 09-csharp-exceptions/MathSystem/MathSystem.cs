namespace MathSystem
{
  public class MathOperations
  {

    public static void Main() {}
    
    public int DivideNumbers(int numberOne, int numberTwo)
    {
      if (numberTwo == 0)
      {
        throw new DivideByZeroException("Não pode dividir um número por zero!");
      }

      return numberOne / numberTwo;
    }
  }
}

// // DESCOMENTAR para ver o funcionamento mais simples
// int DivideNumbers(int numberOne, int numberTwo)
// {
//   return numberOne / numberTwo;
// }

// Console.WriteLine("Resultado 1 = " + DivideNumbers(12, 2));

// try
// {
//   DivideNumbers(12, 0);
// }
// // catch Específico (para caso a exceção seja um Objeto do tipo do parâmetro passado no catch):
// catch (DivideByZeroException except)
// {
//   Console.WriteLine($"Ocorreu um erro específico: {except.Message}");
// }
// // catch Genérico com Objeto "Exception" base:
// // ATENÇÃO: Numa sequência de catches, deve ir por último, pois por ser genérica, captura todos os tipos!!!
// catch (Exception except)
// {
//   Console.WriteLine($"Ocorreu um erro genérico: {except.Message}");
// }

// Console.WriteLine("Resultado 2 = " + DivideNumbers(12, 0)); // Erro: Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.

// ATENÇÃO: Diversas cláusulas catch podem ser lançadas em um bloco de código try, porém somente uma será executada.
// Caso tenha mais de uma cláusula catch, qual será executada?
// Resposta: A primeira que corresponder de maneira mais exata à exceção que está para ser lançada, capturando das mais específicas para as com menores especificidades.
// O indicado é que o tipo de exceção deve ser o mais específico possível. Desta forma, evita-se discrepância entre o que é retornado à pessoa usuária em relação ao que realmente ocorreu.
