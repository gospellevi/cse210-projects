using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activity activity = new Activity();

            while (true)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflecting Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                if (choice == "4")
                {
                    break;
                }
                
                switch (choice)
                {
                    case "1":
                        // activity = new BreathingActivity();
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.DisplayStartingMessage();
                        breathingActivity.Run();
                        breathingActivity.DisplayEndingMessage();
                        
                        break;
                    case "2":
                        // activity = new ReflectingActivity();
                        ReflectingActivity reflectingActivity = new ReflectingActivity();
                        reflectingActivity.DisplayStartingMessage();
                        reflectingActivity.Run();
                        reflectingActivity.DisplayEndingMessage();
                        break;
                    case "3":
                        // activity = new ListingActivity();
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.DisplayStartingMessage();
                        listingActivity.Run();
                        listingActivity.DisplayEndingMessage();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }
            }
        }
    }
}