Random random = new Random();
int daysUntilExpiration = random.Next(0, 13);
int discountPercentage = 0;
    
if (daysUntilExpiration < 1)
{
    Console.WriteLine("Oh no! Your subscription has expired! :( Renew now to continue enjoying our services!");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 30;
    Console.WriteLine("Your subscription expires in only a day!");
    Console.WriteLine($"Renew now and save {discountPercentage}% on your next subscription!");
    Console.WriteLine("Act fast to avoid interruption!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days!");
    Console.WriteLine($"Renew now and get {discountPercentage}% off your renewal!");
    Console.WriteLine("Don't miss out on this limited-time offer, special only for you!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine("Your subscription will expire in a few days. Renew now!");
}
else
{
    Console.WriteLine($"Your subscription is active and will expire in {daysUntilExpiration} days.");
    Console.WriteLine("Enjoy your subscription!");
}

