using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private readonly List<string> reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectionActivity() : base("Reflection Activity", "Reflect on times when you showed strength and resilience.")
    {
    }

    public void StartActivity(int duration)
    {
        base.StartActivity(duration);
        ReflectionCycle(duration);
        base.EndActivity();
    }

    private void ReflectionCycle(int duration)
    {
        Random random = new Random();
        for (int i = 0; i < duration; i++)
        {
            string prompt = reflectionPrompts[random.Next(reflectionPrompts.Count)];
            Console.WriteLine($"\n{prompt}");
            Thread.Sleep(1000);
            AskReflectionQuestions();
        }
    }

    private void AskReflectionQuestions()
    {
        string[] reflectionQuestions =
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        foreach (string question in reflectionQuestions)
        {
            Console.WriteLine($"\n{question}");
            Thread.Sleep(1000);
            Countdown("Next question in", 3);
        }
    }
}
