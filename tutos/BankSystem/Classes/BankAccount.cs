namespace BankSystem.Classes;

public class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }
    private static int s_accountNumberSeed = 1234567890;

    // BankAccount constructor
    public BankAccount(string name, decimal initialBalance)
    {
        this.Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;
        this.Owner = name;
        this.Balance = initialBalance;
    }

    public void MakeDeposite(decimal amount, DateTime date, string note)
    {

    }
    
    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        
    }
}