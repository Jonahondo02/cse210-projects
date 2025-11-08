using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // Random number between 1 and 100

            int guess = 0;
            int numberOfGuesses = 0;
            List<int> previousGuesses = new List<int>(); // To store previous guesses

            // While loop to keep guessing until correct
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numberOfGuesses++;
                previousGuesses.Add(guess); // Store the guess

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {numberOfGuesses} guesses!");
                }
            }

            // For loop to display previous guesses
            Console.WriteLine("Previous guesses:");
            for (int i = 0; i < previousGuesses.Count; i++)
            {
                Console.WriteLine(previousGuesses[i]);
            }

            // Do-While loop to ask if they want to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");
    }
}