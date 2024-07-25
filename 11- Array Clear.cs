string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine($"Array initially: {pallets[0]}");

Random random = new Random();
int numberOfElementsToClear = random.Next(1, pallets.Length + 1);

for (int i = 0; i < numberOfElementsToClear; i++)
{
    int indexToClear = random.Next(pallets.Length);
    pallets[indexToClear] = null!;
}

Array.Clear(pallets, 0, 2);

if (pallets[0] != null)
{
    Console.WriteLine($"Array after clearing: {pallets[0].ToLower()}");
}
else
{
    Console.WriteLine("Array after clearing: null");
}

Console.WriteLine($"Clearing {numberOfElementsToClear} elements:");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet ?? "null"}");
}