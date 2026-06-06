using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who do you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?"
    };

    private Random _rand = new Random();

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Listing Activity\n");
        Console.WriteLine("List positive things in your life.\n");

        GetDuration();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[_rand.Next(_prompts.Count)]);

        Console.Write("\nStart in ");
        ShowCountdown(3);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndActivity("Listing");
    }
}