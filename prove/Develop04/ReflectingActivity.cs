using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };


        public ReflectingActivity() : base()
        {
            _name = "Reflecting Activity";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }


        public void Run()
        {
            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            ShowSpinner(3);

            List<string> sessionQuestions = new List<string>(_questions);

            int elapsed = 0;
            int duration = _duration;

            while (elapsed < duration && sessionQuestions.Count > 0)
            {
                int index = rand.Next(sessionQuestions.Count);
                string question = sessionQuestions[index];
                Console.WriteLine(question);
                sessionQuestions.RemoveAt(index); // Remove the question to avoid repetition
                ShowSpinner(5);
                elapsed += 5;
            }
        }


        public string GetRandomPrompt()
        {
            Random rand = new Random();
            return _prompts[rand.Next(_prompts.Count)];
        }


        public string GetRandomQuestion()
        {
            Random rand = new Random();
            return _questions[rand.Next(_questions.Count)];
        }


        public void DisplayPromt()
        {
            Console.WriteLine(GetRandomPrompt());
        }
        

        public void DisplayQuestion()
        {
            Console.WriteLine(GetRandomQuestion());
        }
    }