namespace AdvancedTypes.Test;
using advancedTypes;

public class UnitTest1
{
    [Fact(DisplayName = "Deve criar lista com tipo genérico.")]
    public void TestCreateGenericList()
    {
        GenericList<int> list1 = new();
        list1.GetType().Should().Be(typeof(GenericList<int>));

        GenericList<string> list2 = new();
        list2.GetType().Should().Be(typeof(GenericList<string>));

        GenericList<SomeClass> list3 = new();
        list3.GetType().Should().Be(typeof(GenericList<SomeClass>));
    }

    [Fact(DisplayName = "Deve retornar um array anonimo com os campos name e number corretamente")]    
    public void TestAnonymousTypes()
    {
        var result = SomeClass.getAllContacts();
        var expected = new[]
            {
                new{name = "John", number = "1111-1111"},
                new{name = "Steve", number = "2222-2222"},
                new{name = "Clara", number = "3333-3333"},
                new{name = "Ana", number = "4444-4444"}
            };
        
        result.Should().BeEquivalentTo(expected);   
    }

    [Theory(DisplayName = "Deve implementar corretamente")]
    [InlineData("Olá", 1)]
    [InlineData("Iae Tryber", 2)]
    [InlineData("Essa é uma frase", 4)]
    public void TestExtensionMethods(string entry, int expected)
    {
        var result = entry.WordCount2();
        result.Should().Be(expected);
    }
}
