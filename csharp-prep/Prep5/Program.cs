using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numberSquared = SquareNumber(number);
        DisplayResults(name, numberSquared);
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program.");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int userNumberSquare = userNumber * userNumber;
            return userNumberSquare;
        }

        static void DisplayResults(string name, int numberSquared)
        {
            Console.WriteLine($"{name}, the square of your number is {numberSquared}.");
        }
}
