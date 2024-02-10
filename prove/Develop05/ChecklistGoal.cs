using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _timesCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _target)
            _points += _bonus;
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _target;
    }

    public override string GetStatusString()
    {
        return $"Completed {_timesCompleted}/{_target} times";
    }
}
