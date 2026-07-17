
// This program must contain the following features:
// Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
// Display the journal - Iterate through all entries in the journal and display them to the screen.
// Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
// Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
// Provide a menu that allows the user choose these options
// Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
// Who was the most interesting person I interacted with today?
// What was the best part of my day?
// How did I see the hand of the Lord in my life today?
// What was the strongest emotion I felt today?
// If I had one thing I could do over today, what would it be?
// Your interface should generally follow the pattern shown in the video demo below.

using System;
// (Creativity):
// Creativity Feature: Added a custom "_mood" property to the Entry class. 
// This allows users to record their mood for the day, providing a more holistic view of their daily experiences.
// saves it as an attribute, displays it in the DisplayAll method, and stores/loads it from the text file.
class Program
{
    static void Main(string[] args)
    {
        // create the basic objects needed for the journal application
        Journal EmadJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        // main loop to display the menu and handle user input
        string userChoice = "";
        Console.WriteLine("Welcome to the Daily Journal Program!");
        // the loop continues until the user chooses to exit (option 5)
        while (userChoice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from a file");    
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                // call a random prompt from the PromptGenerator and create a new Entry with the user's response, current date, and mood
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                // get the user's response 
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                // creativity: ask the user about his/her mood or feeling today, and save it as an attribute of the Entry class
                Console.Write("How are you feeling today? (mood): ");
                string mood = Console.ReadLine();
                // get the current date in a specific format (yyyy-MM-dd)
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                // craete a new Entry object with the date, prompt, response, and mood, and add it to the journal
                Entry newEntry = new Entry(date, prompt, response, mood);
                // add the new entry to the journal
                EmadJournal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                // Display the journal
                EmadJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                // Load the journal from a file
                Console.Write("Enter the filename to load the journal from: ");
                string loadFilename = Console.ReadLine();
                EmadJournal.LoadFromFile(loadFilename);
            }
            else if (userChoice == "4")
            {
                // Save the journal to a file
                Console.Write("Enter the filename to save the journal to: ");
                string saveFilename = Console.ReadLine();
                EmadJournal.SaveToFile(saveFilename);
            }
            else if (userChoice == "5")
            {
                // Exit the program
                Console.WriteLine("Exiting the program. Goodbye!");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }

    }
}

