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

    Console.WriteLine("Os estudantes com a soma de notas acima de 250 são:");
    foreach (var student in studentsWithHighScore)
    {
      Console.WriteLine("Nome: " + student.Name + " | " + "Soma das Notas: " + student.Scores!.Sum());
    }
  }
}
