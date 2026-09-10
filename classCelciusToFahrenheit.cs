Temperature celcius = new Temperature();
Console.Write("Enter temperature in Celcius: ");
double celciusInput = double.Parse(Console.ReadLine());
double fahrenheit = celcius.CelciusToFahrenheit(celciusInput);
Console.WriteLine($"{celciusInput}°C is equal to {fahrenheit}°F");




class Temperature
{
    public double CelciusToFahrenheit(double celcius)
    {
        return (celcius * 9/5) + 32;
    }
}