using System;
using System.Linq.Expressions;


class Program
{
  static void Main(string[] args)
  {

    // Word word1 = new Word("But before ye seek for riches");
    // Console.WriteLine(word1.GetDisplayText());

    // Word word2 = new Word("And after you have obtained a hope in Christ, obtain riches");
    // Console.WriteLine(word2.GetDisplayText());


    // Reference reference1 = new Reference("Jacob", 2, 18);
    // Console.WriteLine(reference1.GetDisplayText());

    // Reference reference2 = new Reference("Jacob", 2, 18, 19);
    // Console.WriteLine(reference2.GetDisplayText());


    // Example scripture with one verse
    Reference referenceOne = new Reference("Jacob", 2, 18);
    Scripture scriptureOne = new Scripture(referenceOne, "But before ye seek for riches, seek ye for the kingdom of God.");

    // Example scripture with two verses
    Reference referenceTwo = new Reference("Jacob", 2, 18, 19);
    Scripture scriptureTwo = new Scripture(referenceTwo, "And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them; and ye will seek them for the intent to do good—to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted.");
    
    // Choose which scripture to display: single verse or two verses.
    // Scripture scripture = scriptureOne;
    Scripture scripture = scriptureTwo;


    while (true)
    {
        Console.Clear();

        // Mimic clearing the console by writing new lines
        // for (int i = 0; i < 30; i++) Console.WriteLine();

        // Display the scripture text
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();

        // Exit the program if the user types 'quit'
        if (input.ToLower() == "quit")
            break;

        // Hide a few random words in the scripture
        scripture.HideRandomWords(3);

        // If all words are hidden, end the program
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            // for (int i = 0; i < 30; i++) Console.WriteLine();

            // Display the scripture text
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are hidden. Program will now end.");
            break;
        }
    }


  }

}

