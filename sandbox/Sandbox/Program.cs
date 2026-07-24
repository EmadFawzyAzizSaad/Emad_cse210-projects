using System;

class Program 
{
    static void Main(string[] args) 
    {
        // 1. (Object)
        Person emad = new Person();

        // 2. (State / Attributes)
        emad._givenName = "Emad";
        emad._familyName = "Saad";

        // 3. (Behavior / Methods)
        emad.ShowEasternName();
        emad.ShowWesternName();
    }
}

// 
public class Person 
{
    // الخصائص والحالة (Attributes & State)
    public string _givenName = "";
    public string _familyName = "";

    
    public Person() 
    { 
    }

    // (Methods & Behavior) - 
    public void ShowEasternName() 
    {
        Console.WriteLine("Eastern Name: " + _familyName + ", " + _givenName);
    }

    public void ShowWesternName() 
    {
        Console.WriteLine("Western Name: " + _givenName + " " + _familyName);
    }
}
 