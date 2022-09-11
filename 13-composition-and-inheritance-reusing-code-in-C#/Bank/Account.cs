namespace Bank;

public class Account
{
  public decimal _balance;

  // Preciso criar a classe Client pra aplicação funcionar!!!
  public Client Owner { get; set; }
  public decimal Balance
  {
    get => _balance;
    set
    {
      if (value < 0) throw new ArgumentException("Balance can't be negative!");
      _balance = value;
    }
  }

  public Account(Client owner)
  {
    Owner = owner;
  }

  public virtual void Deposit(decimal amount) => Balance += amount;
  public void Withdraw(decimal amount) => Balance -= amount;
}
