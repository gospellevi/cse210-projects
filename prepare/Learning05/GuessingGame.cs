// Guessing Game is a type of Game (inheritance)

public class GuessingGame : Game
{
    private int _mystery_number;
    private int _num_guesses;

    // GuessingGame constructor calls the Game constructor
    public GuessingGame() : base("Guessing Game")
    {
        // Randomly select the mystery number 0-100
        Random random = new Random();
        _mystery_number = random.Next(101);
        _num_guesses = 0;
    }

    // Display the start, play the game, and display the end
    // User will get multiple guesses and will be told to 
    // go higher or lower.  The number of guess is tracked.
    public override void Play()
    {
        DisplayStart();  // Calls from Parent class
        int guess = -1;
        do
        {
            _num_guesses += 1;
            Console.Write("What is your guess (0-100): ");
            guess = int.Parse(Console.ReadLine());
            if (_mystery_number == guess)
            {
                Console.WriteLine("Correct!");
                Console.WriteLine($"It took {_num_guesses} guesses.");
            }
            else if (_mystery_number > guess)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower!");
            }
        }
        while (_mystery_number != guess);
        DisplayEnd();  // Calls from Parent class
    }
}