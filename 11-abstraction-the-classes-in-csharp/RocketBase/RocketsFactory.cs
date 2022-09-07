using Program;

class RocketsFactory
{
  public static void Main()
  {
    // Exemplo ilustrativo de atribuição em tipos de referência (reference types) onde copio a referência à instância, fazendo a referência por duas variáveis diferentes
    var rocket1 = new RocketBase();
    var rocket2 = rocket1;

    rocket1.Name = "Apollo 11";
    rocket2.Name = "Falcon 9";

    Console.WriteLine(rocket1.Name); // Saída esperada: Falcon 9

    // Exemplo ilustrativo de não atribuição em tipos de valor (value types) que salvam a informação na própria variável
    var number1 = 1;
    var number2 = number1;

    number2 = 2;

    Console.WriteLine(number1); // Saída esperada: 1

    // Nova instância a partir de classe com Construtor personalizado, com parâmetro/atributo "nome"
    var rocket3 = new RocketWithConstructor("Atlas GX");
    Console.WriteLine(rocket3.Nome); // Saída esperada: Atlas GX
  }
}
