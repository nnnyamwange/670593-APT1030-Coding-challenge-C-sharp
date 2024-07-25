Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);
int total =roll1+roll2+roll3;

Console.WriteLine($"Your rolls: {roll1} +{roll2} + {roll3}");

if ((roll1==roll2) && (roll2==roll3))
{
    Console.WriteLine("Triple Trifecta! You rolled tripples! +6 bonus to total!!");
    total += 6;
}
else if (((roll1==roll2) || (roll2==roll3)  || (roll1==roll3)))
{
    Console.WriteLine("Two peas in a pod! You rolled doubles! +2 bonus to total!");
    total += 2;
}

if (roll1 == 1 && roll2 == 1 && roll3 == 1)
{
    Console.WriteLine("Rats! Triple ones! -5 points penalty!");
    total -= 5;
}

if (roll1 == 6 && roll2 == 6 && roll3 == 6)
{
    Console.WriteLine("WOW! Your luck is out of this world! Lucky number 6! +25 point bonus!");
    total += 1;
}

if (total >= 20)
{
    Console.WriteLine($"Excellent! Your total score is {total}.");
}
else if (total >= 15)
{
    Console.WriteLine($"Congradulations! You win! Your total score is: {total}");
}
else
{
    Console.WriteLine($"Yikes! Better luck next time! Your total score is {total}.");
}

