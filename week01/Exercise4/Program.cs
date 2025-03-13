using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

         List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Step 1: Collect numbers
        do
        {
            Console.Write("Enter number: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);
        
        // Ensure there are numbers in the list for calculations
        if (numbers.Count > 0)
        {
            // Step 2: Calculate sum, average, and max
            int sum = 0;
            int max = numbers[0];

            foreach (int number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }

            double average = (double)sum / numbers.Count;

            // Output results
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }   
}