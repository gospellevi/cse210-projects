using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        
        public Activity()
        {
            _name = "";
            _description = "";
            _duration = 0;
        }

        
        /// Displays the starting message and sets the activity duration.
        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Starting {_name}...");
            Console.WriteLine(_description);
            Console.Write("Enter the duration of the activity in seconds: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);
        }


        /// Displays the ending message with the activity duration.
        public void DisplayEndingMessage()
        {
            Console.WriteLine($"Good job! You have completed the {_name} activity for {_duration} seconds.");
            ShowSpinner(3);
        }

        
        /// Shows a spinner for a specified number of seconds.
        public void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }


        /// Shows a countdown timer for a specified number of seconds
        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Go!");
        }
    }