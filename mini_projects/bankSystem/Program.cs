using bankSystem.classes;

var account = new BankAccount("Loko Ismael", 1000);

Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial Balance");

Console.WriteLine("====================================================");
account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine($"Rent payment -500. New Account Balance : {account.Balance}");
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine($"Deposit of 100. New Account Balance : {account.Balance}");

Console.WriteLine("\n====================================================");

Console.WriteLine("=================== All Transactions ================");
Console.WriteLine(account.GetAccountHistory());
Console.WriteLine("====================================================");
Console.WriteLine("Testing try-catch errors");
// Test that the initial balances must be positive.
BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
    return;
}


// Test for a negative balance.
try
{
    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overview");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw\n ");
    Console.WriteLine(e.ToString());
}