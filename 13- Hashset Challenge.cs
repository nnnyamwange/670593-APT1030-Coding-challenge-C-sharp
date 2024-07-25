int[] A = { -1, 2, -2, 3, -3, 1, 2 };
int uniqueCount = CountUniqueValues(A);
Console.WriteLine($"Number of unique values: {uniqueCount}");

static int CountUniqueValues(int[] A)
{
HashSet<int> abNumbers = new HashSet<int>();

foreach (int number in A)
{
    abNumbers.Add(Math.Abs(number));
}

return abNumbers.Count;
}