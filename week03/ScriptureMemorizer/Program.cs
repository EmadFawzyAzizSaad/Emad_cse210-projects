        // CREATIVITY: I implemented the stretch challenge where the program only selects 
        // random words from the ones that are NOT already hidden. This avoids wasting 
        // turns on already hidden words and makes the program more efficient.


using System;

class Program
{
    static void Main(string[] args)
    {
        


        // will create a reference object (address) and select a verse containing a range.(Proverbs 3:5-6)
        Reference reference = new Reference("2 Nephi", 25, 26, 27);

        // We write all the verse "It's my favorite verse"
        string text = "And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins.Wherefore, we speak concerning the law that our children may know the deadness of the law; and they, by knowing the deadness of the law, may look forward unto that life which is in Christ, and know for what end the law was given. And after the law is fulfilled in Christ, that they need not harden their hearts against him when the law ought to be done away.";

        // will create a large text object and assign it the title and text
        Scripture scripture = new Scripture(reference, text);

        // It will keep working as long as the text isn't completely hidden.
        while (!scripture.IsCompletelyHidden())
        {
            // Scan the black screen to see that the text disappears in the same place
            Console.Clear();

            // We print the current text (with hidden and visible words)
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(); // Empty line

            //Enter /quit
            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit:");
            string userInput = Console.ReadLine(); 

            
            if (userInput.ToLower() == "quit")
            {
                break; // 
            }

            
            scripture.HideRandomWords(3);
        }

        
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nExcellent! You have memorized the scripture!");
    }
}