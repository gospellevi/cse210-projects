using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public string GetDate() // Public getter for date
    {
        return _date;
    }

    public string GetPromptText() // Public getter for prompt text
    {
        return _promptText;
    }

    public string GetEntryText() // Public getter for entry text
    {
        return _entryText;
    }

    public void Display()
    {
        Console.WriteLine("Date: {0}", _date);
        Console.WriteLine("Prompt: {0}", _promptText);
        Console.WriteLine("Entry: {0}", _entryText);
        Console.WriteLine("----------");
    }
}
