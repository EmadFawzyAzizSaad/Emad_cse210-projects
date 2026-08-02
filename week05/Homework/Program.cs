using System;

class Program
{
    static void Main(string[] args)
    {
       

        // 1. Create a base assignment object to test step 1
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine(); // Empty line for clean design

        // 2. Create a MathAssignment object to test step 2
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary()); // Comes from parent class!
        Console.WriteLine(a2.GetHomeworkList()); // Comes from child class!
        Console.WriteLine();

        // 3. Create a WritingAssignment object to test step 3
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary()); // Comes from parent class!
        Console.WriteLine(a3.GetWritingInformation()); // Comes from child class!
    }
}

