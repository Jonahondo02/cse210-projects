using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

          Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guess = 0;
        int guessCount = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
            guessCount++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine($"You guessed it in {guessCount} guesses!");
    }
}