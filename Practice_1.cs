Console.Write($"Enter a number: ");

int num = int.Parse(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine($"The number is positive");
}
 if (num < 0)
{
    Console.WriteLine($"The number is negative");
}
if (num == 0)
{
    Console.WriteLine($"The number is zero");
}