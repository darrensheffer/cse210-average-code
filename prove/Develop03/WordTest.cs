using System;

public class WordTest
{
    // Test string for code
    public string words = "Behold my beloved Son in whom I am well pleased.";

    // Making an empty list to add to later.
    public List<string> wordList = [];
    

    // Code to split a string into a list.
    public List<string> SplitVerse()
    {
        // String[] is an array that takes {words} variable and turns it
        // into seperate instances.  The Split will split the string at 
        // every space.
        string[] wordsSplit = words.Split(" ");

        // Adding the split up words in the array to the empty list.
        foreach (string words in wordsSplit)
        {
            wordList.Add($"{words} ");
        }

        // Return the List
        return wordList;
    }

    public void RemoveWord()
    {    
       // Calling the SplitVerse method to turn string into list.
        SplitVerse();
        
        // Setting up a string for a userInput later in the code.
        string userInput;
        
        // Setting the index i = 0 for lists.
        int i = 0;
        
        // Counter so the code stops removing words when all are gone.
        int x = wordList.Count;
        int y = 1;
        
        Console.WriteLine();

        do
        {
            // If statment will run if list count is greater than or 
            // less than y.
            if (x >= y)
            {
                do
                {
                    // Random number is picked and returned as long as the number
                    // picked is not already a hidden word.
                    Random randomIndex = new Random();
                    i = randomIndex.Next(0, wordList.Count);

                } while (wordList[i] == "_ ");

                wordList[i] = "_ ";
                foreach (string script in wordList)
                    {
                        Console.Write(script);
                    }
                
                // Adds one to the counter.
                y++;
            }
            
            // This else statment should be changed in a way that ends the code
            // while still displaying the verse once it is completely hidden.
            else
            {
               Console.WriteLine("All the words are hidden."); 
            
                foreach (string script in wordList)
                    {
                        Console.Write(script);
                    }

            }

            // I believe this part should be in the Program class, but I just have it here
            // for testing the code.

            // Asking the user if they want to continue or quit. 
            Console.WriteLine("\nPress \"Enter Key\" to continue or enter \"No\" to quit.");
            userInput = Console.ReadLine().ToUpper();

        } while (userInput != "NO");
    }
}