
Console.WriteLine("Enter temperature scale (Fahrenheit write f or Celsius write c):");
char userChoice = Char.Parse(Console.ReadLine());

if (userChoice == 'f')
{
    Console.WriteLine("Enter the temperature in Fahrenheit:")
    double fahrenheit = Convert.ToDouble(Console.ReadLine());
    ConvertToCelsius(double fahrenheit);
}
else if (userChoice == 'c')
{
    Console.WriteLine("Enter the temperature in Celsius:")
    double celsius = Convert.ToDouble(Console.ReadLine());
    ConvertToFahrenheit(double celsius);
}
else
{
    Console.WriteLine("Please use letters c or f.");
}

static void ConvertToCelsius(double fahrenheit)
{
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"Celsius: {celsius}");
}

static void ConvertToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9) / 5 + 32;
    Console.WriteLine($"Fahrenheit: {fahrenheit}");
}
