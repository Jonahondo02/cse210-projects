using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");


    } // Create an instance of GoalManager to track user goals
    GoalManager goalManager = new GoalManager();

    // Adding a feature: track user progress through levels
    // As users gain points, they can "level up" and receive rewards.
    // e.g., Level 1 = 1000 points, Level 2 = 3000 points, etc.

    // Prompts for adding unique "fun" elements, like random badges
    // Every 5 goals completed, a random badge is earned (not required but fun!)

    // Ensure user interaction allows them to create, view, and manage goals.
}