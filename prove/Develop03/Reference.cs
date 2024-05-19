using System.ComponentModel.DataAnnotations;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        // Decide what to set _endVerse equal to
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    // Constructor for multiple verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Returns the formatted reference text
    public string GetDisplayText()
    {
        // Two ways to return the string
        // If no second verse - Jacob 2:18
        // If second verse - Jacob 2:18-19
        if (_endVerse == 0) 
            return _book + " " + _chapter + ":" + _verse;
        else 
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}