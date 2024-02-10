using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayUserScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal} - {goal.GetStatusString()}");
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index]._points;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

}
