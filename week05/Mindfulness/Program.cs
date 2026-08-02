// CREATIVITY: I implemented the strict prompt/question tracking in the Reflection Activity. 
// The program ensures that no random questions are repeated during a single session 
// until all of them have been used. This prevents repetition and improves the user experience.

using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";

        // loop until the user chooses option 4 to quit
        while (userChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            userChoice = Console.ReadLine();

            // user choices
            if (userChoice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (userChoice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (userChoice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
        }

        // goodbye message
        Console.Clear();
        Console.WriteLine("Thank you for using the Mindfulness Program. Stay calm and mindful! Goodbye.");
    }
}
