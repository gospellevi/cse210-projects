public abstract class Game
{
    // All Games have a name
    private string _name;

    // All Games will use this constructor to set the name
    public Game(string name)
    {
        _name = name;
    }

    // Standard start for all games.  Each game should call this function before starting the game.
    public void DisplayStart()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to {_name}!");
        ReadySetGo();       
        Console.WriteLine(); 
    }

    // Standard end for all games.  Each game should call this function when its done.
    public void DisplayEnd()
    {
        Console.WriteLine();
        Console.WriteLine("Game over.  Hope you had fun!");
        Console.WriteLine();
    }

    // Displays Ready, Set, Go with 1 second pause in between each word
    private void ReadySetGo()
    {
        Console.Write("Ready....");
        Thread.Sleep(1000);
        Console.Write(" Set....");
        Thread.Sleep(1000);
        Console.WriteLine(" Go!");
    }

    public abstract void Play();

}