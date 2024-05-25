using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class BreathingActivity : Activity
    {
        public BreathingActivity() : base()
        {
            _name = "Breathing Activity";
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

    
        /// Runs the breathing activity by alternating between "Breathe in..." and "Breathe out..." messages with countdowns.
        public void Run()
        {
            int elapsed = 0;
            int duration = _duration;

            while (elapsed < duration)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(5);
                elapsed += 5;
                if (elapsed >= duration) break;

                Console.WriteLine("Breathe out...");
                ShowCountDown(5);
                elapsed += 5;
            }
        }
    }