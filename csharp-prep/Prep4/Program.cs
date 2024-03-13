using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        
        // Create a list to store numbers
        List<int> numbers = new List<int>();

        // Prompt the user to enter numbers
        Console.WriteLine("Enter a list of numbers type 0 when finished.");

        // Keep looping until the user enters 0
        while (true)
        {
            // Ask the user for a number
            Console.Write("Enter number: ");
            int userNumber = int.Parse(Console.ReadLine());

            // Check if the user entered 0, if so, exit the loop
            if (userNumber == 0)
                break;

            // Append the number to the list
            numbers.Add(userNumber);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int maxNum = numbers.Max();

        Console.WriteLine($"The largest number is: {maxNum}");
    }
}