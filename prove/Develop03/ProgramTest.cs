using System;

class ProgramTest
{
    public static void MainTest(string[] args)
    {
          // Initianize the Word class.
        WordTest list = new();  

        // Run the RemoveWord Method
        list.RemoveWord();
        foreach (string word in list.wordList)
        {
            Console.WriteLine(word);
        }
    }
}
        
        
        // Below is just some more testing and things I am messing around with.
        
        // // Initianize the Scripture class.
        // Scriptures scriptures = new();

        // // Run the Display Method
        // scriptures.Display();
        
        
        // // Initianize the Word class.
        // Word words = new();  

        // ;