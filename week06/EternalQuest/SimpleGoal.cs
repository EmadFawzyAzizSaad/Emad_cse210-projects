// Child class for one-time goals like runing a marathon
using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor passing data to the parent base constructor
    public SimpleGoal(string name, string description, int points, bool isComplete = false) 
        : base(name, description, points)
    {
        _isComplete = isComplete; // default value false at birth
    }

    // Overriding the abstract methods with code
    public override void RecordEvent()
    {
        _isComplete = true; // marked as finished
        Console.WriteLine($"Congratulations! You earned {base.GetPoints()} points!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetShortName()}:{base.GetDescription()}:{base.GetPoints()}:{_isComplete}";
    }
}
