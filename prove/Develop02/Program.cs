using System;
using System.Collections.Generic;
using System.IO;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Console.WriteLine("Hello Develop02 World!");
//         Journal journal = new Journal();
//         PromptGenerator promptGenerator = new PromptGenerator();

//         while (true)
//         {
//             Console.WriteLine("1. Write a new entry");
//             Console.WriteLine("2. Display the journal");
//             Console.WriteLine("3. Save the journal to a file");
//             Console.WriteLine("4. Load the journal from a file");
//             Console.WriteLine("5. Exit");
//             Console.Write("Choose an option: ");
//             string option = Console.ReadLine();

//             switch (option)
//             {
//                 case "1":
//                     string prompt = promptGenerator.GetRandomPrompt();
//                     Console.WriteLine($"Prompt: {prompt}");
//                     Console.Write("Your entry: ");
//                     string entryText = Console.ReadLine();
//                     journal.AddEntry(new Entry(DateTime.Now.ToString(), prompt, entryText));
//                     break;
//                 case "2":
//                     journal.DisplayAll();
//                     break;
//                 case "3":
//                     Console.Write("Enter file name to save: ");
//                     string saveFile = Console.ReadLine();
//                     journal.SaveToFile(saveFile);
//                     break;
//                 case "4":
//                     Console.Write("Enter file name to load: ");
//                     string loadFile = Console.ReadLine();
//                     journal.LoadFromFile(loadFile);
//                     break;
//                 case "5":
//                     Console.WriteLine("Exiting...");
//                     Environment.Exit(0);
//                     break;
//                 default:
//                     Console.WriteLine("Invalid option. Please choose again.");
//                     break;
//             }
//         }
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Add New Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(promptText);
                    Console.Write("Your Entry: ");
                    string entryText = Console.ReadLine();
                    journal.AddEntry(promptText, entryText);
                    Console.WriteLine("Entry added successfully.");
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    continueProgram = false;
                    Console.WriteLine("Exiting Journal.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}