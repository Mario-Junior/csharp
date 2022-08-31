using FluentAssertions;

namespace variable.Test;

public class UnitTest1
{
    [Fact(DisplayName = "Deve criar uma variável do tipo \'string\'")]
    public void TestVariableCreation()
    {
        Class1 instance = new();

        var response = instance.someString is string;
        response.Should().Be(true);
    }

    [Fact(DisplayName = "Deve transformar variável do tipo \'int\' no tipo \'double\'")]
    public void TestTransform()
    {
        Class1 instance = new();
    
        instance.intEntry.Should().Be(42);
        var intTypeCheck = instance.intEntry is int;
        intTypeCheck.Should().Be(true);

        instance.Transform();

        instance.doubleResponse.Should().Be(42.0);
        var floatTypeCheck = instance.doubleResponse is double;
        floatTypeCheck.Should().Be(true);
    }

    [Fact(DisplayName = "Deve converter variável do tipo \'string\' no tipo \'int32\'")]
    public void TestDoConversion()
    {
        Class1 instance = new();
    
        instance.strEntry.Should().Be("42");
        var strTypeCheck = instance.strEntry is string;
        strTypeCheck.Should().Be(true);

        instance.DoConversion();

        instance.intResponse.Should().Be(42);
        var intTypeCheck = instance.intResponse is int;
        intTypeCheck.Should().Be(true);
    }
}
