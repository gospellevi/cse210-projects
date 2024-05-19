using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Program
{
    public static void Main(string[] args)
    {
        // Initialize the list of prompts
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What are you grateful for today",
            "What was the best part of my day?",
            "What made you smile today",
            "How did I see the hand of the Lord in my life today?",
            "What is a challenge you faced today",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"

        };

        // Create instances of PromptGenerator and Journal
        PromptGenerator promptGenerator = new PromptGenerator(prompts);
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Add a new journal entry
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string entryText = Console.ReadLine();
                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToString("yyyy-MM-dd");
                    entry._promptText = prompt;
                    entry._entryText = entryText;
                    journal.AddEntry(entry);
                    break;

                case "2":
                    // Display all journal entries
                    journal.DisplayAll();
                    break;

                case "3":
                    // Save journal to a specified file
                    Console.Write("What is the file name? ");
                    string saveFile = Console.ReadLine();
                    saveFile = string.IsNullOrWhiteSpace(saveFile) ? "JournalFile.txt" : saveFile;
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    // Load journal from a specified file
                    Console.Write("What is the file name? ");
                    string loadFile = Console.ReadLine();
                    loadFile = string.IsNullOrWhiteSpace(loadFile) ? "JournalFile.txt" : loadFile;
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    // Exit the program
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
