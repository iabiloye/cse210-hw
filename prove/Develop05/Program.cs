using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        Goal marathonGoal = new SimpleGoal("Run a Marathon", "Complete a full marathon", 1000);
        Goal scriptureGoal = new EternalGoal("Read Scriptures", "Read scriptures daily", 100);
        Goal templeGoal = new ChecklistGoal("Attend Temple", "Visit the temple", 50, 10, 500);

        goalManager.CreateGoal(marathonGoal);
        goalManager.CreateGoal(scriptureGoal);
        goalManager.CreateGoal(templeGoal);

        goalManager.RecordEvent(0);
        goalManager.RecordEvent(1);
        goalManager.RecordEvent(2);
        goalManager.RecordEvent(2);
        goalManager.RecordEvent(2);

        goalManager.DisplayUserScore();
        goalManager.ListGoals();
    }
}
