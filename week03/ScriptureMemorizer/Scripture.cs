// this will be responsible for the adress(reference)   ans lists and select the hide words

using System;
using System.Collections.Generic; // important word to use the list

public class Scripture
{
    // private variabls
    private Reference _reference;
    private List<Word> _words= new List<Word>();

    // construcutor will recieve the adress and text as string

    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        // will cut off the text to single words:
        string[] splitWords = text.Split(' ');
        // We'll go through the cut-out words and convert each word into a Word object, then put it in the secret list.
        foreach (string wordText in splitWords)
        {
            Word newWord = new Word(wordText);
            _words.Add(newWord);
        }
    }
// the funcation to hide a random word 
// creativity : to creat a list for the words that doesn't hide yet.
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> availableWords = new List<Word>();
        foreach (Word word in _words)
        {
            
             if (!word.IsHidden())
            {
                
                availableWords.Add(word);
            }
        }

        int actualHideCount = Math.Min(numberToHide, availableWords.Count);
        // will start to hide random words from the available list
        for (int i = 0 ; i  < actualHideCount; i++ )
        {
            int randomIndex = random.Next(availableWords.Count);
            availableWords[randomIndex].Hide();  
            availableWords.RemoveAt(randomIndex); // remove to avoid the same word at the turn
        }    
    }
    // to collect the word each other to display on the screen 
    public string GetDisplayText()
    {
        string scriptureText = "";
        
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
                return $"{_reference.GetDisplayText()}\n{scriptureText.Trim()}";
    }
    // the funcation security: to return "true" if the all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; //if it finds even a single word that is NOT hidden, return false

            }
        }
        return true;
    }


}
