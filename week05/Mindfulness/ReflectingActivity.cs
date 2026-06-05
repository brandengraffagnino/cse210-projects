using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }

    public void Run()
    {
    }

    public void DisplayPrompt()
    {
    }

    public void DisplayQuestions()
    {
    }
}