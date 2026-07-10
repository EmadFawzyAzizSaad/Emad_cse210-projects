using System;

class Program
{
    static void Main(string[] args) // The Main method is the entry point of the program
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");
        // static void DisplayMessage()
        // {
        //     Console.WriteLine("Hello world!");
        // }

        // static void DisplayPersonalMessage(string userName)
        // {
        //     Console.WriteLine($"Hello {userName}");
        // }

        // static int AddNumbers(int first, int second)
        // {
        //     int sum = first + second;
        //     return sum;
        // }
        DisplayWelcomeMessage(); // Call the DisplayWelcomeMessage method to display a welcome message
        string name = PromptUserName(); // Call the PromptUserName method to get the user's name and store it in the name variable
        int number = PromptUserNumber(); // Call the PromptUserNumber method to get a number from the user and store it in the number variable
        int squaredNumber = SquareNumber(number); // Call the SquareNumber method to square the number 
        DisplayResult(name, squaredNumber); // Call the DisplayResult method to display the result
        static void DisplayWelcomeMessage() // Method to display a welcome message
        {
            Console.WriteLine("Welcome to the program!"); // Print a welcome message to the console
        }
        static string PromptUserName() // Method to prompt the user for their name
        {
            Console.Write("Please enter your name: "); // Prompt the user to enter their name
            string userName = Console.ReadLine(); // Read the user's input and store it in the userName variable
            return userName; // Return the user's name
        }
        static int PromptUserNumber() // Method to prompt the user for a number
        {
            Console.Write("Please enter your favorite number: "); // Prompt the user to enter a number
            int userNumber = int.Parse(Console.ReadLine()); // Read the user's input, convert it to an integer, and store it in the userNumber variable
            return userNumber; // Return the user's number
        }
        static int SquareNumber(int number) // Method to square a number
        {
            int squared = number * number; // Calculate the square of the number
            return squared; // Return the squared number
        }
        static void DisplayResult(string name, int squaredNumber) // Method to display the result
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}"); // Print the user's name and the squared number to the console
        }
    }
}