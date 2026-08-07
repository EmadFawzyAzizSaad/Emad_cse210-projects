// Child class for ongoing goals that never end
using System;

public class EternalGoal : Goal
{
    // Constructor just passing data up to the parent
    public EternalGoal(string name, string description, string points) 
        : base(name, description, points)
    {
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

    public override string GetStringRepresentation()
    {
        return ""; // stub return
    }
}
