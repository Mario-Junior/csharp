Order myOrder = new();
myOrder.PayType = PaymentType.Credit;

Console.WriteLine("Crédito: " + (int)PaymentType.Credit);
Console.WriteLine("Débito: " + (int)PaymentType.Debit);

enum PaymentType
{
  Credit = 0,
  Debit = 1
}

// Lembrando que, caso eu não defina valores, eles iniciarão como uma lista, sendo o primeiro valor "0" (zero)
// e os demais, incrementando de um em um

class Order
{
  public PaymentType PayType;
}
