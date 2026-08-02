// This class handles the listing exercise, counting user entries.
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count; // private store counting the words typed by the user.
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        base.DisplayStartingMessage();

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine("List as many things as you can in response to the following prompt:");
        Console.WriteLine($"--- {_prompts[promptIndex]} ---");
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);
        Console.WriteLine();

        _count = 0; // Reset the counter before it starts writing
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        //  checks the time with every word it types.
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine(); // The function reads the value typed by the user
            _count++; // Increment the counter with each word typed
        }

        Console.WriteLine($"You listed {_count} items!\n");
        base.DisplayEndingMessage();
    }
}
