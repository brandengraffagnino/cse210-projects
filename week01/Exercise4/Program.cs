using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int greatestNumber = 1;
        int sum = 0;
        while (true)
        {
            Console.Write("Enter number: ");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
            sum += number;
            if (number >= greatestNumber)
            {
                greatestNumber = number;
            }
        } 
        Console.WriteLine($"The sum is: {sum}");
        int amount = numbers.Count();
        double average = (double)sum / amount;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {greatestNumber}");
    }
}