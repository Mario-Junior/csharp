public class A
{
  private string _item = "variável privada";
}

class B : A
{
  static void Main()
  {
    A a = new();
    B b = new();

    // DESCOMENTAR PARA VER O ERRO! Onde não é possível acessar as propriedades privadas de "a" nem de "b" herdadas de "a"
    a._item = "acessando a variável item"; // Erro: "A._item" é inacessível devido ao seu nível de proteção [Private]csharp(CS0122)
    b._item = "acessando a variável item"; // Erro: "B._item" é inacessível devido ao seu nível de proteção [Private]csharp(CS0122)
  }
}
