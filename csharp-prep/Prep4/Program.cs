using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);
            
            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }
        }

        int sumTotal = 0;
        foreach (int number in numbers)
        {
            sumTotal += number;
        }
        Console.WriteLine($"The sum is: {sumTotal}.");

        // double average = 0;
        double average = ((double)sumTotal) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}");

        int min = numbers[0];

        foreach(int number in numbers)
        {
            if (number < min)
            {
                if (number >= 0)
                {
                    min = number;
                }
            }
        }
        Console.WriteLine($"The smallest positive number is: {min}");
    }
}