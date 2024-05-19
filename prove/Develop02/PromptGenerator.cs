using System;
using System.Collections.Generic;



public class PromptGenerator
{
    public List<string> _prompts;

    // Initializes the prompt generator with a list of prompts
    public PromptGenerator(List<string> prompts)
    {
        _prompts = prompts;
    }

    // public List<string> _prompts = new List<string>();


    // Returns a random prompt from the list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}