const int pincode = 1234;
double bankBalance = 1000.00;

Console.WriteLine($"Welcome to ABC atm");
Console.WriteLine($"Please login to your account");
Console.Write($"Please enter your pincode: ");
int pin = int.Parse(Console.ReadLine());

if (pin == pincode)
{
    Console.WriteLine($"Choose your option: ");
    Console.WriteLine($"Show balance (press 1)");
    Console.WriteLine($"Withdraw money (press 2)");
    Console.WriteLine($"Deposit Money (press 3)");
    Console.Write($"Enter your choice: ");

    string choice = Console.ReadLine();

    if(choice == "1")
    {
        Console.WriteLine($"Your current balance is: {bankBalance}");
    }
    else if(choice == "2")
    {
        Console.Write($"Enter the amount to withdraw: ");
        double withdrawAmount = double.Parse(Console.ReadLine());
        double newBalance = bankBalance - withdrawAmount;
        Console.WriteLine($"Balance left: {newBalance}");
    }
    else if(choice == "3")
    {
        Console.Write($"Enter the amount to deposit: ");
        double depositAmount = double.Parse(Console.ReadLine());
        double newBalance = bankBalance + depositAmount;
        Console.WriteLine($"New balance: {newBalance}");
    }
    else
    {
        Console.WriteLine($"Invalid choice");
    }

}

else
{
    Console.WriteLine($"Incorrect pincode");
}