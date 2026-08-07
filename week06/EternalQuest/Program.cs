// CREATIVITY: I added an entirely new type of goal called "NegativeGoal" (Bad Habits). 
// When the user records a negative goal, points are deducted from their total score 
// instead of added, which adds an exciting layer of penalty gamification to break bad habits.

using System;

class Program
{
    static void Main(string[] args)
    {
        // calling the goal manager to fire up the system loop control
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
