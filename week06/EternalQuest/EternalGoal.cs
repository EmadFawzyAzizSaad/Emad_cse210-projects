// Child class for ongoing goals that never end like reading scripture
using System;

public class EternalGoal : Goal
{
    // Constructor just passing data up to the parent
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    // Overriding the abstract methods with code
    public override void RecordEvent()
    {
        // never ends, just give points every time
        Console.WriteLine($"Awesome! You earned {base.GetPoints()} points!");
    }

    // eternal goals never finish so always return false
    public override bool IsComplete()
    {
        return false; 
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{base.GetShortName()}:{base.GetDescription()}:{base.GetPoints()}";
    }
}
