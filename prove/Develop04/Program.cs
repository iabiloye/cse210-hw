using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMindfulness App Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("\nEnter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunBreathingActivity();
                    break;
                case "2":
                    RunReflectionActivity();
                    break;
                case "3":
                    RunListingActivity();
                    break;
                case "4":
                    Console.WriteLine("\nGoodbye!");
                    return;
                default:
                    Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }

    // Run the Breathing Activity with user-specified duration
    static void RunBreathingActivity()
    {
        Console.Write("\nEnter the duration for the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.StartActivity(duration);
    }

    // Run the Reflection Activity with user-specified duration
    static void RunReflectionActivity()
    {
        Console.Write("\nEnter the duration for the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        reflectionActivity.StartActivity(duration);
    }

    // Run the Listing Activity with user-specified duration
    static void RunListingActivity()
    {
        Console.Write("\nEnter the duration for the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.StartActivity(duration);
    }
}
