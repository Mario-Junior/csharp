namespace School;

public class Student
{
  public string? Name { get; set; }
  public int[]? Scores;

  public static Student[] CreateStudents()
  {
    Student[] students = {
      new Student { Name="José", Scores=new int[3] { 100, 90, 80 } },
      new Student { Name="Maria", Scores=new int[3] { 60, 90, 100 } },
    };

    return students;
  }
}
