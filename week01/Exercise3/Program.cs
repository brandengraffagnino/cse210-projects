using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        string correct = "false";
        while (correct == "false")
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            int guess = int.Parse(guessString);
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                correct = "true";
            }
        }
    }
}