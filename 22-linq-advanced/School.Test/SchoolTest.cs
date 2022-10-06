namespace School.Test;

public class SchoolTest
{
    readonly public static TheoryData<Student[], Student> TestDataGetStudentsHighScore = new()
    {
        {
            new Student[]
            {
                new Student { Name="João", Scores=new int[] { 60, 65, 55, 75, 85 } },
                new Student { Name="Maria", Scores=new int[] { 90, 95, 85, 100, 65 } },
            },
            new Student { Name="Maria", Scores=new int[] { 90, 95, 85, 100, 65 } }
        },
    };
    [Theory(DisplayName = "GetStudentWithHighestScore deveria retornar o estudante com maior nota")]
    [MemberData(nameof(TestDataGetStudentsHighScore))]
    public void TestGetStudentWithHighestScore(Student[] studentsEntry, Student expected)
    {
        School instance = new();
        instance.students = studentsEntry;
        var result = instance.GetStudentWithHighestScore();

        result.Should().BeEquivalentTo(expected);
    }

    readonly public static TheoryData<Student[], Student> TestDataGetStudentLowScore = new()
    {
        {
            new Student[]
            {
                new Student { Name="João", Scores=new int[] { 60, 65, 55, 75, 85 } },
                new Student { Name="Maria", Scores=new int[] { 90, 95, 85, 100, 65 } },
            },
            new Student { Name="João", Scores=new int[] { 60, 65, 55, 75, 85 } }
        },
    };
    [Theory(DisplayName = "GetStudentWithLowestScore deveria retornar o estudante com menor nota")]
    [MemberData(nameof(TestDataGetStudentLowScore))]
    public void TestGetStudentWithLowestScore(Student[] studentsEntry, Student expected)
    {
        var instance = new School();
        instance.students = studentsEntry;
        var result = instance.GetStudentWithLowestScore();

        result.Should().BeEquivalentTo(expected);
    }
}
