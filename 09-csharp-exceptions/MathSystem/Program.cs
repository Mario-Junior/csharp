int DivideNumbers(int numberOne, int numberTwo)
{
  return numberOne / numberTwo;
}

Console.WriteLine("Resultado 1 = " + DivideNumbers(12, 2));
Console.WriteLine("Resultado 2 = " + DivideNumbers(12, 0)); // Erro: Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
