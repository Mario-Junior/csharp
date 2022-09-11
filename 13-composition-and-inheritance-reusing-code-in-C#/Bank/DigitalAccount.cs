namespace Bank;

public sealed class DigitalAccount : Account
{
  public OperatingSystem? AccountCreationOS { get; }
  public DateTime AccountCreationDate { get; } = DateTime.Now;

  // Preciso criar a classe Client pra aplicação funcionar!!!
  public DigitalAccount(Client owner, OperatingSystem OS) : base(owner)
  {
    AccountCreationOS = OS;
  }

  public override void Deposit(decimal amount)
  {
    Balance += amount;
    Console.WriteLine($"New balance is {Balance}");
  }
}
