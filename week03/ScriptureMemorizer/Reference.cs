// this class will be responsible for the book name, chapter, and verses

using System;
public class Reference
{
    // private variables  of the address
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    // first constructor : If it's just one verse (without the end of verse)
    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;  // to make the end is the same of beginning  
    }
    // second constructor: if it's a group verses (from verse... to verse ...)
    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // to print the adress with good design to know if it's one verse or group verses:
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}"; // for example (John 10:15)
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";  // for example (John 10:15-17)

        }


    } 

}