int DivideNumbers(int numberOne, int numberTwo)
{
  return numberOne / numberTwo;
}

Console.WriteLine("Resultado 1 = " + DivideNumbers(12, 2));

try
{
  DivideNumbers(12, 0);
}
// catch Específico (para caso a exceção seja um Objeto do tipo do parâmetro passado no catch):
catch (DivideByZeroException except)
{
  Console.WriteLine($"Ocorreu um erro específico: {except.Message}");
}
// catch Genérico com Objeto "Exception" base:
// ATENÇÃO: Numa sequência de catches, deve ir por último, pois por ser genérica, captura todos os tipos!!!
catch (Exception except)
{
  Console.WriteLine($"Ocorreu um erro genérico: {except.Message}");
}

Console.WriteLine("Resultado 2 = " + DivideNumbers(12, 0)); // Erro: Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
