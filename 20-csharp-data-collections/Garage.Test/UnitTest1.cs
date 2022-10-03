namespace Garage.Test;

public class UnitTest1
{
    public static TheoryData<List<string>, string, List<string>> TestAddVehicleData = new()
    {
        {
            // Será o parâmetro vehiclesEntry
            new List<string>{"Bicicleta", "Moto"},

            // Será o parâmetro vehicle
            "Carro",

            // Será o parâmetro vehiclesExpected
            new List<string>{"Bicicleta", "Moto", "Carro"}
        }
    };

    [Theory(DisplayName = "Deve inserir corretamente um carro na garagem")]
    [MemberData(nameof(TestAddVehicleData))]
    public void TestAddVehicle(List<string> vehiclesEntry, string vehicle, List<string> vehiclesExpected)
    {
        // Cria nova garagem
        var instance = new Garage();

        // Atribui os valores de entrada
        instance.Vehicles = vehiclesEntry;

        var numberVehicles = instance.AddVehicle(vehicle);

        // Verifica se os veículos na garagem equivalem aos esperados
        instance.Vehicles.Should().BeEquivalentTo(vehiclesExpected);

        // Verifica se a quantidade retornada é igual a quantidade de veídulos esperados
        numberVehicles.Should().Be(vehiclesExpected.Count);
    }
}
