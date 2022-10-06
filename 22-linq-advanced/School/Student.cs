namespace School;

public class Student
{
  public string? Name { get; set; }
  public int[]? Scores;


  public static Student[] CreateStudents()
  {
    Student[] students = {
      new Student { Name="José", Scores=new int[3] { 60, 90, 100 } },
      new Student { Name="Maria", Scores=new int[3] { 100, 90, 80 } },
    };

    return students;
  }

  public Student GetStudentWithHighestScore()
  {
    var studentWithLowestScore =
      from student in CreateStudents()
      orderby student.Scores!.Max() descending
      select student;

    return studentWithLowestScore.First();
  }

  public Student GetStudentWithLowestScore()
  {
    var studentWithLowestScore =
      from student in CreateStudents()
      orderby student.Scores!.Min()
      select student;

    return studentWithLowestScore.First();
  }
}
