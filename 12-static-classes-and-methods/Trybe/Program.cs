namespace Course;

public class Program
{
  static void Main()
  {
    Trybe.PrintStudents(); // Saída esperada: Luiza, Bruno, Patrícia, Tiago

    Console.WriteLine(Trybe.NumberOfStudents); // Saída esperada: 4

    Trybe.Students = new string[] { "Letícia", "Silvio" };

    Trybe.PrintStudents(); // Saída esperada: Letícia, Silvio
  }
}
