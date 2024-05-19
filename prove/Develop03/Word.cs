public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor that sets the initial visibility of the word
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hides the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Shows the word
    public void Show()
    {
        _isHidden = false;
    }

    // Checks if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns the word text or underscores if hidden
    public string GetDisplayText()
    {
        return _isHidden ? "____": _text;
        
    }


}