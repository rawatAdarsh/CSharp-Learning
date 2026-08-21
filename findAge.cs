Console.WriteLine("Enter Your Name: ");
string name=Console.ReadLine();
Console.WriteLine("Enter current year: ");
string currentYearText=Console.ReadLine();
int currentYear=int.Parse(currentYearText);
Console.WriteLine("Enter Your birth year");
string birthYearText=Console.ReadLine();
int birthYear=int.Parse(birthYearText);

int age=currentYear-birthYear;

Console.Write("Hello ");
Console.WriteLine(name);
Console.Write("You are appoximately ");
Console.Write(age);
Console.Write(" years old.");
