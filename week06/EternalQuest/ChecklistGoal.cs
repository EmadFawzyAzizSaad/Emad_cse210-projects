// Child class for goals that require multiple completions with bonus points
using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor initializing specific fields and passing the rest to base
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) 
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    // Overriding the abstract methods with special behavior logic
    public override void RecordEvent()
    {
        _amountCompleted++; // add 1 to counter
        int totalEarned = base.GetPoints();

        // check if we reached the target to give big bonus
        if (_amountCompleted >= _target)
        {
            totalEarned += _bonus;
            Console.WriteLine($"Fantastic! You finished the target and got a BONUS! Total earned: {totalEarned} points!");
        }
        else
        {
            Console.WriteLine($"Good job! You earned {totalEarned} points!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // we override this because checklist needs to print the counter progress on screen
    public override string GetDetailsString()
    {
        string statusSymbol = IsComplete() ? "X" : " ";
        return $"[{statusSymbol}] {base.GetShortName()} ({base.GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetShortName()}:{base.GetDescription()}:{base.GetPoints()}:{_bonus}:{_target}:{_amountCompleted}";
    }
}
