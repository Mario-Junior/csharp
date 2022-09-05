namespace DeliveryApp.Test;

public class TestCommission
{
    [Theory(DisplayName = "Teste de sucesso para cálculo de comissão")]
    [InlineData(27, 2.7)]
    [InlineData(50, 5)]
    [InlineData(42, 4.2)]
    public void TestCalculationCommissionSuccess(decimal orderPrice, decimal resultExpected)
    {
        var commission = new Commission();
        var result = commission.Calculate(orderPrice);

        result.Should().Be(resultExpected);
    }
}
