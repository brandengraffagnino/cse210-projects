using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a scripture:");
        Console.WriteLine("1 - John 3:16");
        Console.WriteLine("2 - Proverbs 3:5-6");
        string choice = Console.ReadLine();

        Scripture scripture;

        if (choice == "2")
        {
            Reference reference = new Reference("Proverbs", 3, 5, 6);

            scripture = new Scripture(
                reference,
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths"
            );
        }
        else
        {
            Reference reference = new Reference("John", 3, 16);

            scripture = new Scripture(
                reference,
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
            );
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit':");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }
    }
}