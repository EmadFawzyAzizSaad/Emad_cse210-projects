// this class will be responsible for one word in the text
// will know its letters and its hide status
using System;

public class Word
{
    // private variables:
    private string _text;
    private bool _isHidden;

    // The constructor sets up the word as soon as it's created and makes it visible.
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // the word starts visible (not hidden)
    }

    // A general function that makes a word disappear (Setter)
    public void Hide()
    {
        _isHidden = true;
    }

    // A general function that returns whether the word is hidden or not (Getter)
    public bool IsHidden()
    {
        return _isHidden;
    }

    // A function that returns underscores if hidden, or the real text if visible
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // We'll make a dash exactly the same length as the word
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}
