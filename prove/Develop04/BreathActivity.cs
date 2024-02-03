using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "Relax by breathing in and out slowly.")
    {
    }

    // Start the breathing activity with a specified duration
    public void StartActivity(int duration)
    {
        base.StartActivity(duration);
        BreatheCycle(duration);
        base.EndActivity();
    }

    // Perform the breathing cycle for the specified duration
    private void BreatheCycle(int duration)
    {
        int breaths = duration / 2;
        for (int i = 0; i < breaths; i++)
        {
            Countdown("Breathe in...", 3);
            Countdown("Breathe out...", 3);
        }
    }
}
