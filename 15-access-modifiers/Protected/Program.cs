namespace Protected;

public class A
{
  protected string item = "atributo protegido";
}

class B : A
{
  static void Main()
  {
    A a = new();
    B b = new();

    // DESCOMENTAR PARA VER O ERRO! Onde não é possível acessar as propriedades protegidas de "a"
    // a.item = "acessando o atributo item"; // Erro: Não é possível acessar membro protegido "A.item" através de um qualificador do tipo "A"; o qualificador deve ser do tipo "B" (ou derivado dele) [Protected]csharp(CS1540)

    b.item = "acessando e modificando a variável item em b que herda de a";

    Console.WriteLine(b.item);
  }
}
