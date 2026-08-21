//string numberText=Console.ReadLine();
Console.Write("Enter a number between 1 and 10: ");
int number = int.Parse(Console.ReadLine());

if (number >=1 && number <=10)
{
    Console.WriteLine("The number is between 1 and 10");
    Console.WriteLine($"The square of the number is: {number * number}");
}
else
{
    Console.WriteLine("The number is not between 1 and 10");
}