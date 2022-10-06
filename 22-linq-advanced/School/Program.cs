namespace School;

public class Program
{
  public static void Main()
  {
    Student[] students = Student.CreateStudents();

  // Posso utilizar o Sum também diretamente dentro de uma consulta LINQ
    var studentsWithHighScore = 
      from student in students
      where student.Scores!.Sum() > 250
      select student;

    Console.WriteLine("$ Método .Sum:");
    Console.WriteLine("Os estudantes com a soma de notas acima de 250 são:");
    foreach (var student in studentsWithHighScore)
    {
      Console.WriteLine("Nome: " + student.Name + " | " + "Soma das Notas: " + student.Scores!.Sum());
    }
    Console.WriteLine("------------------------------------------------------------------------");

  // Método .Max()
    Console.WriteLine("$ Método .Max:");
    // Imprimir a maior nota do primeiro estudante usando o método Max
    Console.WriteLine("Nome: " + students[0].Name + " | " + "Maior nota: " + students[0].Scores!.Max());

    // Diretamente dentro de uma consulta LINQ
    var studentsWithMaxScoreEqual100 = 
      from student in students
      where student.Scores!.Max() == 100
      select student;
    foreach (var student in studentsWithMaxScoreEqual100)
    {
      Console.WriteLine("Estudantes com nota Máxima | Nome: " + student.Name);
    }
    Console.WriteLine("------------------------------------------------------------------------");

  // Método .Min()
    // Imprimir a menor nota do primeiro estudante usando o método Min
    Console.WriteLine("Nome: " + students[0].Name + " | " + "Menor nota: " + students[0].Scores!.Min());

    // Diretamente dentro de uma consulta LINQ
    var studentsWithAScoreLessThan70 = 
      from student in students
      where student.Scores!.Min() <= 70
      select student;
    
    Console.WriteLine("Os estudantes com menor nota menor ou igual a 70 são:");
    foreach (var student in studentsWithAScoreLessThan70)
    {
      Console.WriteLine("Nome: " + student.Name + " | " + "Menor nota: " + student.Scores!.Min());
    }
    Console.WriteLine("------------------------------------------------------------------------");

    Console.WriteLine("Teste de método: " + Student.GetStudentWithHighestScore().Name);
  }
}
