public class ReflectionActivity : Activity
{
    private List<string> _promts = new List<string>
    {
        "Who do you know that you are thankful for?",
        "What is something you did today that you are proud of?",
        "Who would you consider your Hero?  And Why?",
        "What would be benificial for you to plan on tomorrow?",
        "Who have you helped today?"
    };

    private List<string> _questions = new List<string>
    {
        "How was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was completed?",
        "What is your favorite thing about this expirence?"
    };

    public ReflectionActivity() : base("Reflection Activity", 
    "This activity will help you reflect on times in your life when you have" + 
    "\nshown strength and resilience. This will help you recognize the power" + 
    "\n you have and how you can use it in other aspects of your life.")
    {}

    public void RunReflectionActivity()
    {
        DisplayStartMessage();
        DisplayRandomPrompt();

        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        CountdownAnimation("You may begin in: ", 5);
        Console.Clear();

        int duration = GetDuration();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        while (currentTime < endTime)
        {
            DisplayQuestion();
            currentTime = DateTime.Now;
            if (currentTime >= endTime) {break;}
        }
        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNum = random.Next(0, _promts.Count());
        string randomPrompt = _promts[randomNum];
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomNum = random.Next(0, _questions.Count());
        string randomQuestion = _questions[randomNum];
        return randomQuestion;
    }

    public void DisplayRandomPrompt()
    {
        string randomPrompt = GetRandomPrompt();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n --- {randomPrompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press 'Enter' to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        string randomQuestion = GetRandomQuestion();

        Console.WriteLine($"> {randomQuestion} ");
        SpinAnimation();
    }
}