Console.Write($"Enter your age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"Your age is: {age}");
if (age>=18)
{   
    Console.WriteLine($"Your are eligible to vote");
}
else
{
    //Console.WriteLine($"Your age is: {age}");
    Console.WriteLine($"Your are not eligible to vote");
}