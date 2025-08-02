using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            AnimateBreathing("Breathe in...", 4);
            AnimateBreathing("Hold...", 2);
            AnimateBreathing("Breathe out...", 4);
        }

        DisplayEndingMessage();
    }

    // Added simple animation for breathing activity
    private void AnimateBreathing(string message, int seconds)
    {
        Console.WriteLine($"\n{message}");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("o");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
