namespace CompareDates.Test;

public class UnitTest1
{
    
    [Theory(DisplayName = "Deve retornar o relacionamento entre as datas")]
    [InlineData("2012/10/21", "2022/10/21", "antes")]
    [InlineData("2011/10/21", "2001/10/21", "depois")]
    [InlineData("2022/10/21", "2022/10/21", "igual")]
    public void TestCompareDates(string date1, string date2, string expected)
    {
        DatesCompare dates = new();

        var d1 = DateTime.Parse(date1);
        var d2 = DateTime.Parse(date2);
        var result = dates.CompareDates(d1, d2);
        result.Should().Be(expected);
    }

}
