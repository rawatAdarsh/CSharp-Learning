Console.Write($"Enter a number: ");
int num = int.Parse(Console.ReadLine());

if (num >= 90 && num <=100)
{
    Console.WriteLine($"The grade is 'A'. This is Excellent");
}
else if ( num >=75 && num <=89)
{
    Console.WriteLine($"The grade is 'B'. This is Very Good");
}
else if (num >=60 && num <=74)
{
    Console.WriteLine($"The grade is 'C'. This is Good");
}
else if (num >=40 && num <=59)
{
    Console.WriteLine($"The grade is 'D'. This is Pass");
}
else if (num <40)
{
    Console.WriteLine($"The grade is 'F'. This is Fail");
}
