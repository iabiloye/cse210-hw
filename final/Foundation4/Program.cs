using System;
using System.Collections.Generic;

namespace PolymorphismWithExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running("2024-02-22", 36, 3.2));
            activities.Add(new Cycling("2024-02-22", 48, 15.6));
            activities.Add(new Swimming("2024-02-22", 58, 23));

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
