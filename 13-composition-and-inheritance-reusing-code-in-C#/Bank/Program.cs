using System;
namespace Bank;

class Program
{
  static void Main()
  {
    Client newClient = new("Tryber");

    Account newAccount = new(newClient);

    DigitalAccount newDigital = new(newClient, Environment.OSVersion);

    Console.WriteLine(newDigital.Owner);
    Console.WriteLine(newDigital.AccountCreationDate);
    Console.WriteLine(newDigital.AccountCreationOS);

    newAccount.Deposit(1000);
    Console.WriteLine(newAccount.Balance);

    newDigital.Deposit(500);
  }
}
