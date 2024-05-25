// Math Game is a type of Game (inheritance)

public class MathGame : Game
{
    // MathGame constructor calls the Game constructor
    public MathGame() : base("Math Game")
    {
    }

    // Display the start, play the game, and display the end
    // User has to solve an addition problem.
    public override void Play()
    {
        DisplayStart();  // Calls from Parent class

        Random random = new Random();
        int a = random.Next(10);
        int b = random.Next(10);
        Console.Write($"What is {a} + {b}? ");
        int guess = int.Parse(Console.ReadLine());
        if (guess == a+b)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine($"Incorrect!  Answer was {a+b}");
        }

        DisplayEnd();  // Calls from Parent class
    }
}