Console.Write($"Enter a number: ");
int num = int.Parse(Console.ReadLine());
int remainder = num % 2;
Console.WriteLine($"The remainder is: {remainder}");
if (remainder == 0)
{
   // Console.WriteLine($"The remainder is: {num % 2}");
    Console.WriteLine($"The number is even");
}
if (remainder != 0)
{
    Console.WriteLine($"The number is odd");
}