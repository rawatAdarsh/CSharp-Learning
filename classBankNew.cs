
bankAccount account1 = new bankAccount();
account1.balance = 10000; 
account1.Deposit("Amit", 500);
account1.Deposit("Amit", -200);
account1.Withdraw("Amit", 15000);
account1.Withdraw("Amit", 100);
account1.showBalance("Amit");


bankAccount account2 = new bankAccount();
account2.balance = 15000;
account2.Deposit("Rahul", 500);
account2.Deposit("Rahul", -200);
account2.Withdraw("Rahul", 20000);
account2.Withdraw("Rahul", 100);
account2.showBalance("Rahul");

class bankAccount
{
    //public string accountHolder;
    public double balance;
    public void Deposit(string accountHolder, double amount)
    {
        Console.WriteLine($"Current balance of {accountHolder}'s account: Rs.{balance}");
        Console.WriteLine($"Depositing amount in {accountHolder}'s account.");
        if (amount>0)
        {
        balance = balance + amount;
        }
        else
        {
        Console.WriteLine("Invalid deposit amount. Please enter a positive amount.");
        }
        Console.WriteLine($"Balance after depositing: Rs.{balance}");
    }

    public void Withdraw(string accountHolder, double amount)
    {
        Console.WriteLine($"Current balance of {accountHolder}'s account: Rs.{balance}");
        Console.WriteLine($"Withdrawing amount from {accountHolder}'s account.");
        if (amount > 0 && amount <= balance)
        {
            balance = balance - amount;
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount. Please enter a valid amount.");
        }
        Console.WriteLine($"Balance after withdrawing: Rs.{balance}");
        
    }

    public void showBalance(string accountHolder)
    {
        Console.WriteLine($"Current balance in {accountHolder}'s account: Rs.{balance}");
    }
}