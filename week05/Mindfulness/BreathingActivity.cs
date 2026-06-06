using System;

public class BreathingActivity : Activity
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Breathing Activity\n");
        Console.WriteLine("This helps you relax by breathing slowly.\n");

        GetDuration();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(3);

            Console.Write("\nBreathe out... ");
            ShowCountdown(3);

            Console.WriteLine();
        }

        EndActivity("Breathing");
    }
}