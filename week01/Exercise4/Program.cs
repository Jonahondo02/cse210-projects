using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        if (numbers.Count > 0)
        {
            // Calculate sum
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            // Calculate average
            double average = (double)sum / numbers.Count;

            // Find maximum
            int max = numbers[0];
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            // Find smallest positive number
            int? smallestPositive = null;
            foreach (var number in numbers)
            {
                if (number > 0 && (smallestPositive == null || number < smallestPositive))
                {
                    smallestPositive = number;
                }
            }

            // Sort the list
            numbers.Sort();

            // Display results
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
            if (smallestPositive.HasValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers.");
            }

            // Display sorted list
            Console.WriteLine("The sorted list is:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}