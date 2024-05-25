// Code Word Game is a type of Game (inheritance)

public class CodeWordGame : Game
{
    private string _word;

    // CodeWordGame constructor calls the Game constructor
    public CodeWordGame() : base("Code Word Game")
    {
        // Randomly select a word
        Random random = new Random();
        List<string> words = new List<string>() {
            "apple", "pear", "orange", "watermelon"
        };
        int index = random.Next(words.Count);
        _word = words[index];
    }

    // Display the start, play the game, and display the end
    // The word is coded by shifting it by 1 letter
    public override void Play()
    {
        DisplayStart();  // Calls from Parent class

        string coded = "";
        foreach (char c in _word)
        {
            // Convert the letter to the ASCII number, add 1 to it, then convert
            // it back to a character
            coded += (char)((int) c + 1);
        }
        Console.WriteLine($"Here is the coded word: {coded}");
        Console.Write("What is the uncoded word? ");
        string guess = Console.ReadLine();
        if (guess == _word)
        {
            Console.WriteLine("You got it!");
        }
        else
        {
            Console.WriteLine($"Nope ... the answer was: {_word}");
        }

        DisplayEnd();  // Calls from Parent class
    }
}