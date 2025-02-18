using System;
using System.ComponentModel;

class Program
{


    public static void Main(string[] args)
    {
        Console.Clear();

        string userSelection;
        
        Reference referenceEasy = new Reference("1Nephi", 3, 7);
        Reference referenceNormal = new Reference("Moroni", 10, 4, 5);
        
        Verse verse = new Verse("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Verse firstVerse = new Verse("And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.");
        Verse secondVerse = new Verse("And by the power of the Holy Ghost ye may know the truth of all things.");



        

        Scripture scriptureEasy = new Scripture(referenceEasy, verse);
        Scripture scriptureNormal = new Scripture(referenceNormal, firstVerse, secondVerse);
        // Scripture scriptureHard = new Scripture(referenceHard, verseHard);
        
        Console.WriteLine(@"
      --- Welcome to the ---
--- Scripture Mastery Program! ---

To start, please select a difficutly:
Enter ""E"" for Easy
Enter ""N"" for Normal
Or enter Quit to exit.
");
        Console.Write("What is your choice? ");

        do
        {
            userSelection = Console.ReadLine().ToUpper();

            if (userSelection == "E")         
            {
                do
                {
                    scriptureEasy.Display();
                    userSelection = Console.ReadLine().ToUpper();
                    
                    if (userSelection == "")
                    {            
                        scriptureEasy.Display();
                        bool anything = verse.RemoveRandomWords();
                        
                        if (anything == false)
                        {
                            Console.WriteLine("Thanks for using the app.\n");
                            return;
                        }
                    }
                    else if (userSelection == "QUIT")
                    {
                        Console.WriteLine("Thanks for using the app.\n");
                        return;
                    }
                } while (userSelection != "QUIT");
            }

            if (userSelection == "N")         
            {
                do
                {
                    scriptureNormal.Display();
                    userSelection = Console.ReadLine().ToUpper();
                    
                    if (userSelection == "")
                    {            
                        scriptureNormal.Display();
                        bool anything = firstVerse.RemoveRandomWords();
                        bool anything1 = secondVerse.RemoveRandomWords();
                        
                        if (anything == false && anything1 == false)
                        {
                            Console.WriteLine("Thanks for using the app.\n");
                            return;
                        }
                    }
                    else if (userSelection == "QUIT")
                    {
                        Console.WriteLine("Thanks for using the app.\n");
                        return;
                    }
                } while (userSelection != "QUIT");
            }

        } while (userSelection != "QUIT");
    }
}