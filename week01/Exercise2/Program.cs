using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");
        // if x > y:
        // print("greater than")
        // int x = 5;
        // int y = 10;
        // int z = 15;
        // if (x < y)
        // {
        //     if (x < z)
        //     Console.WriteLine("greater than BOTH");
        // Console.Write ("How old are you? ");
        // int age = int.Parse(Console.ReadLine());
        // Console.Write ("How old is your friend? ");
        // int friendAge = int.Parse(Console.ReadLine());
        // Console.Write ("How old is your brother? ");
        // int brotherAge = int.Parse(Console.ReadLine());
        // int x = age;
        // int y = friendAge;
        // int z = brotherAge;
        // if (x < y)
        // {
        //     Console.WriteLine("Your are younger than your friend");
        // }
        // else if (x < z)
        // {
        //     Console.WriteLine("Your are younger than your brother");
        // }
        
        // else
        // {
        //     Console.WriteLine("You are older than either of them.");
        // }
        // Console.Write ("What is your name? ");
        // string yourname = Console.ReadLine();
        // Console.Write ("What is your friend's name? ");
        // string yourfriendname = Console.ReadLine();
        // Console.Write ("What is your brother's name? ");
        // string yourbrothername = Console.ReadLine();
        // if (yourname == "Emad" || yourname == "Sara" || yourname == "Mayvan" || yourname == "Marolla")
        // {
        //     Console.WriteLine("You have a Family name!");
        // }
        // else if (yourfriendname == "John" || yourfriendname == "Mary" || yourfriendname == "David" || yourfriendname == "James")
        // {
        //     Console.WriteLine("You have a biblical name!");
        // }

        // else
        // {
        //     Console.WriteLine("You don't either biblical name or family name.");
        // }
        Console.Write ("What is your grade presentage in last semester? ");
        int yourgrade = int.Parse(Console.ReadLine());
        string lettergrade = "";
        string sign = ""; // empty string to hold the sign for the letter grade (e.g., + or -)
        if (yourgrade >= 90)
        {
            lettergrade = "A";
        }
        else if (yourgrade >= 80)
        {
            lettergrade = "B";
        }
        else if (yourgrade >= 70)
        {
            lettergrade = "C";
        }
        else if (yourgrade >= 60)
        {
            lettergrade = "D";
        }
        else
        {
            lettergrade = "F";
        }
        // Stretch Challenge:
        // more than 7 (last number 10%) = +
        // less than 3 (last number 10%) = -
        int lastnumber = yourgrade % 10;
        if (lastnumber >= 7)
        {
            sign = "+";
        }
        else if (lastnumber < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        // expectaios Cases :
        // more than 96 = A only
        // less than 60 = F only
        // if lettergrade == "A" && sign == ++ "remove the sign"
        if (lettergrade == "A" && sign == "+")
        {
            sign = "";
        }
        // if lettergrade == "F" either "-" or "+" "remove any signs and consider "F" only
        if (lettergrade == "F" && (sign == "+" || sign == "-"))
        {
            sign = "";
        }
        Console.WriteLine($"Your letter grade is {lettergrade}{sign}.");
        if (yourgrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the semester.");
        }
        else
        {
            Console.WriteLine("Don't give up! You can do it next semester.");
        }

    }
}