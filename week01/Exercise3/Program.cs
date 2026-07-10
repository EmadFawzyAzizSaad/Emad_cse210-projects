using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // int count = 1;
        // while (count <= 10)
        // {
        //     Console.WriteLine($"This is count {count}");
        //     count = count + 1;
        // }
        // Console.WriteLine("Done counting to 10.");
        // string answer = "yes";
        // while (answer == "yes")
        // {
        //     Console.Write ("Do you want to continue? (yes/no) "); // input
        //     answer = Console.ReadLine(); // wait for user input
        // }
        // Console.WriteLine("Thank you for using the program. Goodbye!"); // user's input is not "yes", exit the loop and print a goodbye message  

        // string answer ;
        // do
        // {
        //     Console.Write ("Do you want to continue? (yes/no) "); // input
        //     answer = Console.ReadLine(); // wait for user input
        // } while (answer == "yes");
        // Console.WriteLine("Thank you for using the program. Goodbye!"); // user's input is not "yes", exit the loop and print a goodbye message
        //  for (int i = 0; i <= 10; i++)
        // {
        //     Console.WriteLine($"This is count {i}");
        // }
        // for (int i = 2; i <= 20; i += 2)
        // {
        //     Console.WriteLine($"This is count {i}");
        // }

        // Guess My Number
        Random randomGenerator = new Random();
        string anotherGame ;
        do
        {
            int magicnumber = randomGenerator.Next(1, 101); // generate a random number between 1 and 100
            int guess = -1;
            int guessCount = 0;
            Console.WriteLine("Welcome to Guess My Number game! I have picked a magic number between 1 and 100.");
            
            
            while (guess != magicnumber)
            {
                Console.Write("guess a number: ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
                if (guess < magicnumber)
                {
                    Console.WriteLine("Higher.");
                }
                else if (guess > magicnumber)
                {
                    Console.WriteLine("Lower.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                }
            }
            Console.WriteLine($"You guessed the number in {guessCount} attempts.");
            Console.Write("Do you want to play again? (yes/no) ");
            anotherGame = Console.ReadLine();
        } while (anotherGame == "yes");

        

    }
}