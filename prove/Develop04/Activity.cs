public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"\n{_description}");
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        SpinAnimation();

        Console.WriteLine();

    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        SpinAnimation();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        SpinAnimation();
    }

    public void SpinAnimation()
    {
        List<char> chars = new List<char>{'/', '-', '\\', '|'};

        for (int i = 0; i < 10; i++)
            foreach (char c in chars)
            {
                Console.Write("\b \b");
                Console.Write(c);
                Thread.Sleep(250);
            }
        Console.Write("\b \b");
        Console.WriteLine("");
    }

    public void CountdownAnimation(string message, int startNumber)
    {
        Console.Write($"{message}");
        
        for (int currentNumber = startNumber; currentNumber > 0; currentNumber--)
        {
            Console.Write(currentNumber);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }

    public int GetDuration() {return _duration;}
}