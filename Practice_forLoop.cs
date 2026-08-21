//for(int i = 0; i <= 10; i++)
//{
   // Console.WriteLine($"The value of i is: {i}");
//}

//for (int i = 10; i >=0; i--)
//{
  //  Console.WriteLine($"The value of i is: {i}");
//}

//Code for table 
Console.Write($"Enter a number: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"Enter the Length of the table: ");
int tableLength = int.Parse(Console.ReadLine());

for (int i = 1; i<=tableLength; i++)
{
    Console.WriteLine($"{num} * {i} = {num * i}");
}