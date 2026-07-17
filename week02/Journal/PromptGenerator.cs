// required quastons: (state, behavior)
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;


// state: list of prompts
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "What was the most challenging part of your day?",
            "Which verse of scripture did you read today, and how did it impact you?",
            "If you had one thing you could do over today, what would it be?"
        };
    }
// Behavior: GetRandomPrompt method to return a random prompt from the list:
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}