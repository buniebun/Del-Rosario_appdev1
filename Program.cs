using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Divine Rose A. Del Rosario  BSIT 3-3");
        Console.WriteLine();
        Console.WriteLine("==========================");
        Console.WriteLine("  🐾 Snoopy's Number Game");
        Console.WriteLine("==========================");
        Console.WriteLine();
        Console.WriteLine("Snoopy picked a secret number between 1 and 10.");
        Console.WriteLine("Can you guess it?");
        Console.WriteLine();

        // Generate a random number between 1 and 10
        Random random = new Random();
        int secretNumber = random.Next(1, 11);
        int tries = 0;

        // Keep asking until the player guesses correctly
        while (true)
        {
            Console.Write("Your guess: ");
            string input = Console.ReadLine();

            // Check if it's a valid number
            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Please enter a valid number!");
                continue;
            }

            tries++;

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Try higher. 🐾");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high! Try lower. 🐾");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("🎉 Correct! The number was " + secretNumber + "!");
                Console.WriteLine("You got it in " + tries + " tries!");
                Console.WriteLine();
                Console.WriteLine("Snoopy says: Good job, Charlie Brown! and GOOD GRIEF!!");
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}