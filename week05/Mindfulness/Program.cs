using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Program Started");

        BreathingActivity breathing = new BreathingActivity(
            "Breathing",
            "This activity helps you relax by breathing slowly.",
            30
        );

        breathing.Run();
    }
}