//Console.Write("Enter Temperature in Celcius: ");
//string CelciusTemp=Console.ReadLine();
//int CelciusTempReal=int.Parse(CelciusTemp);
//double fahrenheit = (CelciusTempReal * (9/5.0))+32;
//Console.WriteLine(fahrenheit);
int fahrenheit = 94;
decimal celcius = (fahrenheit -32) * (5.0m/9.0m);
Console.WriteLine($"Celcius: {celcius}");
Console.WriteLine("The tempeature in Celcius is: " + celcius);