using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    private readonly List<string> listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "List as many things as you can in a certain area.")
    {
    }

    // Start the listing activity with a specified duration
    public void StartActivity(int duration)
    {
        base.StartActivity(duration);
        ListingCycle(duration);
        base.EndActivity();
    }

    // Perform the listing cycle for the specified duration
    private void ListingCycle(int duration)
    {
        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Thread.Sleep(1000);
        Countdown("Start listing in", 3);

        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;

        while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
        {
            Console.Write("\nEnter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"\nNumber of items entered: {items.Count}");
    }
}
