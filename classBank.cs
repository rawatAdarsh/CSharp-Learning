BankAccount Account1 = new BankAccount();
Account1.accountHolder = "Rahul";
Account1.balance = 10000;
Account1.Deposit();
Account1.Deposit();
Account1.Withdraw();
Account1.Withdraw();
Account1.ShowBalance();

BankAccount Account2 = new BankAccount();
Account2.accountHolder = "Amit";
Account2.balance = 15000;
Account2.Deposit();
Account2.Deposit();
Account2.Withdraw();
Account2.Withdraw();
Account2.ShowBalance();

class BankAccount
{
    public string accountHolder;
    public double balance;

    public void Deposit()
    {
        //Console.WriteLine($"Current balance is: Rs {balance}.");
        Console.WriteLine($"Depositing money to {accountHolder}'s account.");
        balance = balance + 100;
        Console.WriteLine($"Balance after deposititng: {balance}.");
    }

    public void Withdraw()
    {
        //Console.WriteLine($"Current balance is: Rs {balance}.");
        Console.WriteLine($"Withdraw money from {accountHolder}'s account.");
        balance = balance - 50;
        Console.WriteLine($"Balance after withdrawing: {balance}.");
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Current balance of {accountHolder}'s account is: {balance}.");
    }
}