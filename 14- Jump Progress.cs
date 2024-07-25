class JumpCalculator
{
    public int Jumps(int X, int Y, int Z)
    {
        if (X >= Y)
        {
            return 0;
        }
        
        int distanceToCover = Y - X;
        int count = (distanceToCover + Z - 1) / Z;

        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        JumpCalculator calculator = new JumpCalculator();

        int X, Y, Z;

        Console.Write("Enter the starting position (X): ");
        while (!int.TryParse(Console.ReadLine(), out X))
        {
            Console.Write("Invalid input. Please enter a valid integer for X: ");
        }

        Console.Write("Enter the target position (Y): ");
        while (!int.TryParse(Console.ReadLine(), out Y))
        {
            Console.Write("Invalid input. Please enter a valid integer for Y: ");
        }

        Console.Write("Enter the jump distance (Z): ");
        while (!int.TryParse(Console.ReadLine(), out Z))
        {
            Console.Write("Invalid input. Please enter a valid integer for Z: ");
        }

        int jumps = calculator.Jumps(X, Y, Z);

        Console.WriteLine($"To jump from a starting position of {X} to an ending position of {Y} with a jump distance of {Z}, you need at least {jumps} jumps.");
    }
}
