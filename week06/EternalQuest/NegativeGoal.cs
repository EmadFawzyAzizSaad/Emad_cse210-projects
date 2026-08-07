// CREATIVITY: Child class for bad habits that cost you points from total score
using System;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // bad habit subtracts points instead of add to score
        Console.WriteLine($"Oh no! You did a bad habit and lost {base.GetPoints()} points! Be careful next time!");
    }

    public override bool IsComplete()
    {
        return false; // negative habits are eternal struggle inside life
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{base.GetShortName()}:{base.GetDescription()}:{base.GetPoints()}";
    }
}
