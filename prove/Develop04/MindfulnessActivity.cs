using System;
using System.Threading;

public class MindfulnessActivity
{
    public string Name { get; }
    public string Description { get; }
    public int Duration { get; private set; }

    // Constructor for initializing name and description
    public MindfulnessActivity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    // Start the activity with a specified duration
    public void StartActivity(int duration)
    {
        Duration = duration;
        Console.WriteLine($"\n{Name} - {Description}");
        Console.WriteLine($"Set the duration for this activity: {Duration} seconds.");
        Countdown("Prepare to begin", 3);
    }

    // End the activity, displaying a completion message
    public void EndActivity()
    {
        Console.WriteLine("\nGreat job! You have completed the activity.");
        Console.WriteLine($"{Name} - Duration: {Duration} seconds.");
        Countdown("Returning to the main menu", 3);
    }

    // Display a countdown with a specified message and duration
    protected static void Countdown(string message, int seconds)
    {
        Console.WriteLine(message);
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}...");
            Thread.Sleep(1000);
        }
    }
}
