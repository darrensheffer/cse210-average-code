using System;
using System.Net.Http.Headers;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
    /** Code for inputing specific magic number **/
        // Console.WriteLine("What is the magic number?");
        // string magicNumberanswer = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberanswer);

        /** Random Number Generator **/

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        int guess = -10;
        Console.WriteLine("Guess a number between 1 and 100.");
        int guessCounter = 0;
        int replay = 0;


        // while (replay != 2)
        // {
            while (guess != magicNumber)
            {  
                Console.WriteLine("What is your guess?");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
                guessCounter++;
                
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    Console.WriteLine("");
                }

                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    Console.WriteLine();
                }
                
                else
                {
                    Console.WriteLine("You Got It!");
                    Console.WriteLine($"You guessed it in {guessCounter} guesses.");
                }
            }
        // Console.WriteLine("");
        // Console.WriteLine("You Win!");
        // Console.WriteLine("Would you like to play again?");
        // Console.WriteLine("Enter 1 for yes or 2 for no.");
        // string replayAnswer = Console.ReadLine();
        // replay = int.Parse(replayAnswer);
        // }
    }
}