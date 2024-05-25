using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

//  class ListingActivity : Activity
//     {
//         private List<string> _prompts = new List<string>
//         {
//             "Who are people that you appreciate?",
//             "What are personal strengths of yours?",
//             "Who are people that you have helped this week?",
//             "When have you felt the Holy Ghost this month?",
//             "Who are some of your personal heroes?"
//         };

//         public ListingActivity()
//         {
//             _name = "Listing Activity";
//             _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
//         }

//         protected override void Run()
//         {
//             Random rand = new Random();
//             string prompt = _prompts[rand.Next(_prompts.Count)];
//             Console.WriteLine(prompt);
//             ShowCountDown(5);

//             int count = 0;
//             int elapsed = 0;
//             while (elapsed < _duration)
//             {
//                 Console.Write("Enter an item: ");
//                 Console.ReadLine();
//                 count++;
//                 elapsed += 5;  // Assuming each entry and pause takes 5 seconds
//             }

//             Console.WriteLine($"You listed {count} items.");
//         }
//     }

  class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base()
        {
            _name = "Listing Activity";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            _count = 0;
            // _prompts = new List<string>();
        }
        // public ListingActivity()
        // {
        //     SetNameAndDescription(
        //         "Listing Activity",
        //         "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        //     );
        // }

        /// <summary>
        /// Runs the listing activity by prompting the user to list items related to a specific area of strength or positivity.
        /// </summary>
        public void Run()
        {
            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            ShowCountDown(5);

            int count = _count;
            int elapsed = 0;
            // int duration = GetDuration();
            int duration = _duration;

            while (elapsed < duration)
            {
                Console.Write("Enter an item: ");
                Console.ReadLine();
                count++;
                elapsed += 5;  // Assuming each entry and pause takes 5 seconds
            }

            Console.WriteLine($"You listed {count} items.");
        }

        public void GetRandomPrompt()
        {
            Random rand = new Random();
            Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        }

        public List<string> GetListFromUser()
        {
            return new List<string>();
        }
    }