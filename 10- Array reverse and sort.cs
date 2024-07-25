Random random = new Random();
string[] pallets = new string[6];

for (int i = 0; i < pallets.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 100).ToString("00");
    pallets[i] = prefix + suffix;
}

Console.WriteLine("A Randomly Generated List:");
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("Sorted array ....");
Array.Sort(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("Array in reverse ....");
Array.Reverse(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}