using System;
using System.Collections.Generic; // Called to use the List class

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");
        // List<string> words = new List<string>();
        // words.Add("Emad");
        // words.Add("phone");
        // words.Add("computer");
        // words.Add("laptop"); 
        // Console.WriteLine("The list of words contains:");
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        //     Console.WriteLine("count: " + word.Length);
        // }  
        // create a list of integers empty list
        List<int> numbers = new List<int>();
        // like input in the python and consider 0 number to exit the loop
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        // intialize a variable to hold the user input
        int userinput = -1;
        // while loop to get user input doesn't equal 0
        while (userinput != 0)
        {
            Console.Write("Enter a number: ");
            userinput = int.Parse(Console.ReadLine());
            if (userinput != 0)
            {
                numbers.Add(userinput);
            }
        }
        // TO SUM THE NUMBERS IN THE LIST
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number; // TO SUM THE NUMBERS IN THE LIST ON THE CURRENT ITERATION
        }
        Console.WriteLine($"The sum is: {sum}");
        // TO FIND THE AVERAGE OF THE NUMBERS IN THE LIST WITH DECIMAL POINTS
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        // TO FIND THE MAXIMUM NUMBER IN THE LIST
        // int max = numbers[0];   // to avoid the error of empty list, we can use int.MinValue instead of numbers[0]
        int max = int.MinValue; // Initialize to the smallest possible integer
        int smallestpositive = int.MaxValue; // Initialize to the largest possible integer
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            // TO FIND THE SMALLEST POSITIVE NUMBER IN THE LIST
            if (number > 0 && number < smallestpositive)
            {
                smallestpositive = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestpositive}");
        // to sort the list of numbers in ascending order
        numbers.Sort();
        Console.WriteLine("The sorted list is: "); 
        foreach (int number in numbers)
        {
            // Console.Write(number + " "); // print the sorted list in one line
            Console.WriteLine(number); // print the sorted list in multiple lines
        } 
        Console.WriteLine(); // print a newline at the end

    }
}