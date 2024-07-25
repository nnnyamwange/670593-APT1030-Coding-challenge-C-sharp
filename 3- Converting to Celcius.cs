int fahrenheit = 100;

decimal celsius = (fahrenheit - 32m) * 5m / 9m;
decimal kelvin = celsius + 273.15m;

Console.WriteLine($"The temperature is {Math.Round(celsius)} degrees Celsius");
Console.WriteLine($"The temperature is {Math.Round(kelvin)} Kelvin");



