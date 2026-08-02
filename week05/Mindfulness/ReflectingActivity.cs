// This class handles the reflection exercise, prompt and question logic.
using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    // private lists to store prompts and questions for the reflection activity
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // to prevent the questions randomly without repeating them, we need to keep track of the available questions in a separate list.
    private List<string> _availableQuestions = new List<string>();

    public ReflectingActivity() 
        : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        base.DisplayStartingMessage();

        // get a random prompt
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {_prompts[promptIndex]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine(); // The function waits for the user to press Enter

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);
        Console.Clear();

        // to clone the list of questions into the available questions list
        _availableQuestions = new List<string>(_questions);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        while (DateTime.Now < endTime)
        {
            // if the available questions list is empty, we reset it to the original list of questions to ensure that we can continue asking questions without conflict.
            if (_availableQuestions.Count == 0)
            {
                _availableQuestions = new List<string>(_questions);
            }

            // choose a random question from the available questions list
            int questionIndex = random.Next(_availableQuestions.Count);
            string currentQuestion = _availableQuestions[questionIndex];

            Console.Write($"> {currentQuestion} ");
            base.ShowSpinner(10); // show spinner animation for 10 seconds
            Console.WriteLine();

            // creativity: remove the asked question from the available questions list to avoid repeating it in the same session.
            _availableQuestions.RemoveAt(questionIndex);
        }

        base.DisplayEndingMessage();
    }
}
