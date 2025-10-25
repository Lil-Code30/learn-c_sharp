using BankSystem.Classes;

var account = new BankAccount("Loko Ismael", 1000);

Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial Balance");
