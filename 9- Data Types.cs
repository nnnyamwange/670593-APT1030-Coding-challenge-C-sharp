Console.WriteLine("Choose a signed integral type to see its range:");
Console.WriteLine("1. sbyte (8-bit signed integer)");
Console.WriteLine("2. short (16-bit signed integer)");
Console.WriteLine("3. int (32-bit signed integer)");
Console.WriteLine("4. long (64-bit signed integer)");

Console.Write("Choose a number: ");
string userchoice = Console.ReadLine();

switch (userchoice)
{
    case "1":
        ShowRange("sbyte", sbyte.MinValue, sbyte.MaxValue);
        break;
    case "2":
        ShowRange("short", short.MinValue, short.MaxValue);
        break;
    case "3":
        ShowRange("int", int.MinValue, int.MaxValue);
        break;
    case "4":
        ShowRange("long", long.MinValue, long.MaxValue);
        break;
    case "5":
        Console.WriteLine("No such choice. Try again.");
        break;
}

static void ShowRange(string typeName, long minValue, long maxValue)
{
    Console.WriteLine($"{typeName}'s range is:");
    Console.WriteLine($"   Minimum Value: {minValue}");
    Console.WriteLine($"   Maximum Value: {maxValue}");
}