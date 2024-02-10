using System;

public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _completed = false;
    }

    public override void RecordEvent()
    {
        _completed = true;
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override string GetStatusString()
    {
        return _completed ? "[X] Completed" : "[ ] Not Completed";
    }
}
