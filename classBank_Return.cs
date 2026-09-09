BankAccount account = new BankAccount();
account.balance = 1000;

double newBalance = account.Deposit(500);
double newBalance2 = account.Deposit(-200);
Console.WriteLine($"New balance after deposit: Rs.{newBalance}");
Console.WriteLine($"Balance after invalid deposit: Rs.{newBalance2}");

double newBalance3 = account.Withdraw(200);
double newBalance4 = account.Withdraw(-100);
Console.WriteLine($"New balance after withdrawal: Rs.{newBalance3}");
Console.WriteLine($"Balance after invalid withdrawal: Rs.{newBalance4}");

account.ShowBalance();



class  BankAccount
{
    public double balance;

    public double Deposit(double amount)
    {
        Console.WriteLine($"Current balance: Rs.{balance}");
        if(amount>0)
        {
            balance = balance + amount;
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Please enter a positive amount.");
        }
        return balance;
    }

    public double Withdraw(double amount)
    {
        Console.WriteLine($"Current balance: Rs.{balance}");
        if (amount>0 && amount <= balance)
        {
            balance = balance - amount;
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount. Please enter a valid amount.");
        }
        return balance;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Current balance is: Rs.{balance}");
    }
}