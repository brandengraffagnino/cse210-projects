using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>();
    }

    public void Run()
    {
    }

    public void GetUserList()
    {
    }
}