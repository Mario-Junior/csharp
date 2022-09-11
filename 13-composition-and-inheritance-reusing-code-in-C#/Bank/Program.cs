using System;
namespace Bank;

class Program
{
  static void Main()
  {
    Client newClient = new("Tryber");

    Account newAccount = new(newClient);

    DigitalAccount newDigital = new(newClient, Environment.OSVersion);

    Console.WriteLine(newClient.Name);
    Console.WriteLine(newDigital.AccountCreationDate);
    Console.WriteLine(newDigital.AccountCreationOS);

    Console.Write("Depósito em conta comum: "); newAccount.Deposit(1000);
    Console.WriteLine(newAccount.Balance);

    Console.Write("Depósito em conta Digital! "); newDigital.Deposit(500);
  }
}
