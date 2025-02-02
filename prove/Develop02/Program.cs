using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        List<string> savedEntries = new List<string>();

        do
        {
            Console.WriteLine("Wecome to your personal electronic journal!");
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do?" );
            userInput = int.Parse(Console.ReadLine());
            
            if (userInput == 1)
            {
                Prompt prompt1 = new Prompt();
                Console.WriteLine($"Your prompt is: {prompt1.Display()}");
                string _userEntry = Console.ReadLine();
                savedEntries.Add(_userEntry);
            }

            else if (userInput == 2)
            {
                Console.WriteLine("Answers entered:");
                foreach (string _userEntry in savedEntries)
                {
                    Console.WriteLine(_userEntry);
                }

            }

            else if (userInput == 3)
            {
                Console.WriteLine("Print 3");

            }

            else if (userInput == 4)
            {
                Console.WriteLine("Print 4");

            }

            else if (userInput == 5)
            {
                Console.WriteLine("Print 5");
            }

            else
            {
                Console.WriteLine("Please enter a number between 1 and 5.");
            }
        
        }while (userInput != 5);
        
        
    }
}