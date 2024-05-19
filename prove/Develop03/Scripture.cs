using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


     // Constructor that splits the scripture text into individual words
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Hides a specified number of random words that are not already hidden
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> wordsToHide = _words.Where(word => !word.IsHidden()).OrderBy(_ => random.Next()).Take(numberToHide).ToList();
        // wordsToHide.foreach(w => w.Hide());

        foreach (Word word in wordsToHide)
        {
            word.Hide();
        }
    }

    // Returns the formatted scripture text with hidden words replaced by underscores
    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        // return $"{_reference.GetDisplayText()}\n{scriptureText}";
        return $"{_reference.GetDisplayText()} {scriptureText}";


    }

    // Checks if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}