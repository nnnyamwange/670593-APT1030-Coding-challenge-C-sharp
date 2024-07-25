Random random = new Random();
string[] orderIDs = new string[5];


string[] prefixes = { "N", "0", "X", "J", "F" };
for (int i = 0; i < orderIDs.Length; i++)
{
    string prefix = prefixes[random.Next(prefixes.Length)];
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = $"{prefix}-{suffix}";
}

Console.WriteLine($"Your randomized orderIDs are:");
foreach (string orderID in orderIDs)
{
    Console.WriteLine(orderID);

}
