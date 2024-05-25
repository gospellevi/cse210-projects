class Program
{
    // Simple menu to test out the game classes.
    static void Main(string[] args)
    {
        string choice = "0";
        do
        {
            Console.WriteLine("Game Menu");
            Console.WriteLine("1) Guessing Game");
            Console.WriteLine("2) Code Word Game");
            Console.WriteLine("3) Math Game");
            Console.WriteLine("4) Exit");
            Console.Write("Your choice: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                GuessingGame g = new GuessingGame();
                g.Play();
            }
            else if (choice == "2")
            {
                CodeWordGame g = new CodeWordGame();
                g.Play();
            }
            else if (choice == "3")
            {
                MathGame g = new MathGame();
                g.Play();
            }
        }
        while (choice != "4");
        Console.WriteLine("Goodbye!");
    }
}