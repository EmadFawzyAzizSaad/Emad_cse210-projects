// required : date and response

using System;
public class Entry
{

    // Attributes: the basic features of the class (state of objects) 
    public string _date;
    public string _prompt;
    public string _response;

    // creativity: to ask the user about his/her mood or feeling today, and save it as an attribute of the Entry class
    public string _mood;
    // methods and operations: the behaviors of the class (what the objects can do)
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"Mood today: {_mood}"); // creativity: display the mood of the user today
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine("-----------------------------------");
    }
    // Constructor: to initialize the attributes of the class when creating an object
    public Entry(string date, string prompt, string response, string mood)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _mood = mood;
    }
}