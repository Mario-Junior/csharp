string[] chemicalProducts = new string[3];

try
{
  chemicalProducts[0] = "Cálcio";
  chemicalProducts[1] = "Zinco";
  chemicalProducts[2] = "Hidrazina";
  chemicalProducts[3] = "Anilina";
}
catch (IndexOutOfRangeException exc)
{
  Console.WriteLine("Erro Específico: sabemos exatamente o motivo do erro.");
}
catch (Exception exc)
{
  Console.WriteLine("Temos a mensagem, porém é um pouco incerto o que ocorreu.");
}
