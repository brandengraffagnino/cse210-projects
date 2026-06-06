using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you did something hard.",
        "Think of a time you showed courage."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made it special?"
    };

    private Random _rand = new Random();

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Reflecting Activity\n");
        Console.WriteLine("Think about meaningful experiences.\n");

        GetDuration();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[_rand.Next(_prompts.Count)]);

        ShowSpinner(2);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n" + _questions[_rand.Next(_questions.Count)]);
            ShowSpinner(3);
        }

        EndActivity("Reflecting");
    }
}