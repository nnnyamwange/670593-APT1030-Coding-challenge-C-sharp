Random dice = new Random();

int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"Roll 1, random integer): {roll1}");
Console.WriteLine($"Roll 2, between 0 and 100: {roll2}");
Console.WriteLine($"Roll 3, between 50 and 100: {roll3}");

int sum = roll1 + roll2 + roll3;
Console.WriteLine($"Total sum of your rolls: {sum}");

double average = (roll1 + roll2 + roll3) / 3.0;
Console.WriteLine($"Average value of rolls: {Math.Round(average, 2)}");

if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine(" All rolls are the same! You have triples!");
}

if (roll1 > 90 && roll2 > 90 && roll3 > 90)
{
    Console.WriteLine("Congradulations! ALL rolls are above 90! High roll!");
}