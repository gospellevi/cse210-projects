using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? "); //Asks user for magic number
        // int magicNum = int.Parse(Console.ReadLine());
        // Console.Write("What is your guess? "); //Asks user to guess 
        // int guessNum = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random(); //Using Random function to generate random number
        int magicNum = randomGenerator.Next(1, 101);

        int numOfGuesses = 0;

        while (true)
        {
            Console.Write("What is your guess? "); //Asks user to guess 
            int guessNum = int.Parse(Console.ReadLine());

            numOfGuesses++;

            if (magicNum == guessNum) //Condition for if guess is equal to magic number
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {numOfGuesses} attempts.");
            }
            else if (guessNum < magicNum) //Condition for if guessed ujber is lesser than magic number
            {
                Console.WriteLine("Guess higher");
            }
            else //Condition for if guessed number is higher than magic number 
            {
                Console.WriteLine("Guess lower");
            }


        }
    
    }
}