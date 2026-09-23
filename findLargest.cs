int[] numbers = new int[5];

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write("Enter your number: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int largest = numbers[0];
for(int i = 1; i < numbers.Length; i++)
{
 if (numbers[i] > largest)
    {
        largest = numbers[i];
    }   
}

Console.WriteLine("All five numbers are: ");
for(int i = 0; i<numbers.Length; i++)
{
    Console.Write($"{numbers[i]}, ");
}

Console.WriteLine($"Largest number is: {largest}");