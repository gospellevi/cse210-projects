using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); //Calls function to display message

        string userName = PromptUserName(); //calls function into a variable
        // Console.WriteLine($"Your name is {userName}"); //Prints to console

        int userFavNumber = PromptUserNumber();
        // Console.WriteLine($"Your favorite number is {userFavNumber}");

        int squaredNum = SquareNumber(userFavNumber);

         DisplayResult(userName, squaredNum);
    }

        static void DisplayWelcome() //Create a function that displays welcome message
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName() // Create a function that prompts user for name
        {
            Console.Write("What is your name? ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string userName, int squaredNum)
    
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNum}");
        }

       

}