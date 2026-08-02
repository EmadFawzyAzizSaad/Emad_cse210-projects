// This class handles the breathing exercise, helping the user relax with timed breathing.
using System;

public class BreathingActivity : Activity // ":" the sign of heritance from the parent
{
    // Constructor to initialize the name and description for the breathing activity
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // main function to run this activity
    public void Run()
    {
        // 1. call the welcome funcation from the parent class
        base.DisplayStartingMessage();

        // 2. calculate the end time based on the duration set by the user
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        // 3. the loop continues until the duration is finished
        while (DateTime.Now < endTime) // 👈 زودنا السطر الإجباري ده هنا عشان اللوب تشتغل صح
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            base.ShowCountDown(4); // Breathe in for 4 seconds with countdown timer

            Console.Write("\nBreathe out... ");
            base.ShowCountDown(6); // Breathe out for 6 seconds with countdown timer
            Console.WriteLine();
        }

        // 4. call the ending message function from the parent class
        base.DisplayEndingMessage();
    }
}
