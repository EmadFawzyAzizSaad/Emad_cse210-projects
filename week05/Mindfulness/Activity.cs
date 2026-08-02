// This class is the base parent class for all activities.
// It encapsulates shared data like name, description, and duration.
// we will create other three classes as childern

using System;
using System.Threading; // to work the sleep method and time methods.

public class Activity
{
    // private variables for safety and matching with Naming Conventions
    private string _name;
    private string _description;
    private int _duration;

    // Constructor to initialize the name and description for any generic activity
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // get/set because the user enters it externally
    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // welcome function: to print the activity name and description, asks the user for the time
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine()); // to recieve the time and keep the variable privatly and safely
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5); // We're showing a 5-second loading animation for style.
        Console.WriteLine();
    }

    // the end of funcation to congatulate the user and show the total time of the activit
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    // method to show a spinning stick on the screen for a few seconds
    public void ShowSpinner(int seconds)
    {
        // We will make a list containing the shapes of the stick twist one after the other
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        // The loop continues spinning and printing the shapes until the time is up
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250); // pause for 250 milliseconds
            Console.Write("\b \b"); // erase the character using backspace

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0; // restart
            }
        }
    }

    // Countdown function: Displays 5,4,3,etc...., in the same location
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // wait a second between each number
            Console.Write("\b \b"); // clean the old number by backspace
        }
    }
}
