// Child class for goals that require multiple completions
using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor initializing specific fields and passing the rest to base
    public ChecklistGoal(string name, string description, string points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Overriding the abstract methods with empty stubs for now
    public override void RecordEvent()
    {
        // stub empty body
    }

    public override bool IsComplete()
    {
        return false; // stub return
    }

    public override string GetDetailsString()
    {
        return ""; // stub return
    }

    public override string GetStringRepresentation()
    {
        return ""; // stub return
    }
}
