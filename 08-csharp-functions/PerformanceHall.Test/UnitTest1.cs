namespace PerformanceHall.Test;

public class TestAge
{
    [Theory(DisplayName = "Valida a maioridade a partir do ano de nascimento")]
    [InlineData(2013, false)]
    [InlineData(1980, true)]
    [InlineData(2000, true)]
    public void TestIsOfLegalAge(int yearOfBitrh, bool resultExpected)
    {
        var ageClass = new Age();

        var age = ageClass.CalculateAgeByYear(yearOfBitrh);

        var isOfLegalAge = ageClass.ValidateComingOfAge(age);

        isOfLegalAge.Should().Be(resultExpected);
    }
}
