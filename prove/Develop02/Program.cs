using System;

// Save functionality was split into "Add to File" and Overwrite
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int userInput;

        Console.WriteLine("Welcome to your electronic journal program!");

        do
        {
            Console.WriteLine("\nPlease select one of the following:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Overwrite\n5. Add to File\n6. Quit");
            Console.Write("What would you like to do? ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                journal.AddEntry();
            }
            else if (userInput == 2)
            {
                journal.DisplayAll();
            }
            else if (userInput == 3)
            {
                journal.LoadFile();
            }
            else if (userInput == 4)
            {
                // Add to file
                journal.Save();
            }
            else if (userInput == 5)
            {           
                // Overwrite file     
                journal.Save(true);
            }
            else if (userInput == 6)
            {
                Console.WriteLine("Goodbye!");
            }
        } while (userInput != 6);
    }
}