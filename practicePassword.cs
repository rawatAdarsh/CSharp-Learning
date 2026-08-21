string password = "";

while (password != "secret")
{
    Console.Write($"Enter the correct password: "); 
    password = Console.ReadLine();   
}
Console.WriteLine($" ");
Console.WriteLine($"You have entered the correct password. Access granted.");